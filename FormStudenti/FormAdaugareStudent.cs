using LibrarieModele;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BD_SituatieScolara
{
    public partial class FormAdaugareStudent : Form
    {
        private readonly IStocareStudenti stocareStudenti = (IStocareStudenti)new StocareFactory().GetTipStocare(typeof(Student));
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private readonly IStocareProgrameStudii stocareProgrameStudii = (IStocareProgrameStudii)new StocareFactory().GetTipStocare(typeof(ProgramStudiu));
        private const int PRIMA_COLOANA = 0;
        private List<Facultate> listFacultati;
        private List<ProgramStudiu> listProgramStudiu;
        private bool itemAdaugat = false;

        // Selectie form
        private int idFacultateSelected;
        private string cicluStudiuSelected;
        private string specializareSelected;

        public FormAdaugareStudent()
        {
            InitializeComponent();
            listFacultati = stocareFacultati.GetFacultati();
            listProgramStudiu = stocareProgrameStudii.GetProgrameStudii();
        }

        #region Form events

        #region Form

        private void FormAdaugareStudent_Load(object sender, EventArgs e)
        {
            comboBoxCicluStudiu.Enabled = false;
            comboBoxSpecializare.Enabled = false;
            comboBoxAn.Enabled = false;

            IncarcareComboBox.IncarcaDenumiriFacultati(comboBoxFacultate, listFacultati);
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (itemAdaugat == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
                this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            try
            {
                ClearResetFormComponents.ResetColors(panelInputs.Controls.OfType<Label>());
                Student student = ValideazaInformatii();
                if (student == null)
                    return;
                if(stocareStudenti.ValideazaExistenta(student))
                {
                    MessageBox.Show("Studentul deja exista");
                    return;
                }

                var rezultat = stocareStudenti.AddStudent(student);

                if (rezultat == true)
                {
                    itemAdaugat = true;
                    MessageBox.Show("Studentul a fost adaugat");
                    ClearResetFormComponents.ClearInputs(panelInputs.Controls.OfType<Control>());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Studentul nu a fost adaugat cu succes");
            }
        }


        #region ComboBox events

        private void comboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = 144;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (ComboItem s in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(s.Text, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }


        private void comboBox_EnabledChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if(comboBox.Enabled == false)
            {
                comboBox.Items.Clear();
                comboBox.SelectedIndex = -1;
            }
        }

        private void comboBoxFacultate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFacultate.SelectedIndex == -1)
                return;

            comboBoxCicluStudiu.Enabled = true;
            comboBoxSpecializare.Enabled = false;
            comboBoxAn.Enabled = false;

            comboBoxCicluStudiu.Items.Clear();
            idFacultateSelected = ((ComboItem)comboBoxFacultate.SelectedItem).Id;
            IncarcareComboBox.IncarcaProgrameStudiiFacultate(comboBoxCicluStudiu, listProgramStudiu, idFacultateSelected);
        }

        private void comboBoxProgramStudiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCicluStudiu.SelectedIndex == -1)
                return;
            comboBoxSpecializare.Enabled = true;
            comboBoxAn.Enabled=false;

            comboBoxSpecializare.Items.Clear();
            cicluStudiuSelected = ((ComboItem)comboBoxCicluStudiu.SelectedItem).Text;

            IncarcareComboBox.IncarcaSpecializariFacultate(comboBoxSpecializare, listProgramStudiu,
               idFacultateSelected, cicluStudiuSelected);
        }
        private void comboBoxSpecializare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSpecializare.SelectedIndex == -1)
                return;

            comboBoxAn.Enabled = true;
            comboBoxAn.Items.Clear();

            specializareSelected = ((ComboItem)comboBoxSpecializare.SelectedItem).Text;

            IncarcareComboBox.IncarcaAniStudent(comboBoxAn, listProgramStudiu,
                 idFacultateSelected, cicluStudiuSelected, specializareSelected);
        }

        #endregion

        #region PlaceHolders
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "example@yahoo.com")
                textBox.Text = "";
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (String.IsNullOrEmpty(textBox.Text))
                textBox.Text = "example@yahoo.com";
        }

        private void textBoxTelefon_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "07XXXXXXXX")
                textBox.Text = "";
        }

        private void textBoxTelefon_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (String.IsNullOrEmpty(textBox.Text))
                textBox.Text = "07XXXXXXXX";
        }
        #endregion



        #endregion


        #region Functii

        private Student ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var numeValid = ValidareString.ValideazaDenumire(textBoxNume.Text);
                if (string.IsNullOrEmpty(numeValid.Text))
                {
                    mesajEroare.Append($"{labelNume.Text} : {numeValid.Mesaj}\n");
                    labelNume.ForeColor = Color.Red;
                }

                var prenumeValid = ValidareString.ValideazaDenumire(textBoxPrenume.Text);
                if (string.IsNullOrEmpty(prenumeValid.Text))
                {
                    mesajEroare.Append($"{labelPrenume.Text} : {prenumeValid.Mesaj}\n");
                    labelPrenume.ForeColor = Color.Red;
                }

                var emailValid = ValidareString.ValideazaEmail(textBoxEmail.Text);
                if (string.IsNullOrEmpty(emailValid.Text))
                {
                    mesajEroare.Append($"{labelEmail.Text} : {emailValid.Mesaj}\n");
                    labelEmail.ForeColor = Color.Red;
                }

                var telefonValid = ValidareString.ValideazaNumarTelefon(textBoxTelefon.Text);
                if (string.IsNullOrEmpty(telefonValid.Text))
                {
                    mesajEroare.Append($"{labelTelefon.Text} : {telefonValid.Mesaj}\n");
                    labelTelefon.ForeColor = Color.Red;
                }

                if (comboBoxFacultate.SelectedIndex == -1)
                {
                    mesajEroare.Append($"{labelFacultate.Text} Selecteaza o optiune\n");
                    labelFacultate.ForeColor = Color.Red;
                }

                if (comboBoxCicluStudiu.SelectedIndex == -1)
                {
                    mesajEroare.Append($"{labelProgramStudiu.Text} Selecteaza o optiune\n");
                    labelProgramStudiu.ForeColor = Color.Red;
                }
                if (comboBoxSpecializare.SelectedIndex == -1)
                {
                    mesajEroare.Append($"{labelSpecializare.Text} Selecteaza o optiune\n");
                    labelSpecializare.ForeColor = Color.Red;
                }
                if (comboBoxAn.SelectedIndex == -1)
                {
                    mesajEroare.Append($"{labelAn.Text} Selecteaza o optiune\n");
                    labelAn.ForeColor = Color.Red;
                }

                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }


                var programStudiu = listProgramStudiu.Where(p => p.Ciclu == cicluStudiuSelected && p.Specializare == specializareSelected && p.IdFacultate == idFacultateSelected)
                                                     .Select(p => p.IdProgramStudiu)
                                                     .FirstOrDefault();

                var anStudent = Convert.ToInt32(comboBoxAn.SelectedItem.ToString());

                return new Student(numeValid.Text, prenumeValid.Text, emailValid.Text, telefonValid.Text, anStudent, programStudiu);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la validarea informatiilor despre student");
            }

            return null;
        }

        #endregion

        
    }
}
