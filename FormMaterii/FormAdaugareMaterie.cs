using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace Proiect_BD_SituatieScolara
{
    public partial class FormAdaugareMaterie : Form
    {
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private readonly IStocareMaterii stocareMaterii = (IStocareMaterii)new StocareFactory().GetTipStocare(typeof(Materie));
        private List<Facultate> listFacultati;
        private bool itemAdaugat = false;


        public FormAdaugareMaterie()
        {
            InitializeComponent();
            listFacultati = stocareFacultati.GetFacultati();
            IncarcareComboBox.IncarcaDenumiriFacultati(comboBoxFacultate, listFacultati);

        }

        private void FormAdaugareMaterie_Load(object sender, EventArgs e)
        {
            comboBoxProgramStudiu.Enabled = false;
            comboBoxSpecializare.Enabled = false;
            comboBoxAn.Enabled = false;
        }

        #region Form Events
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
                Materie materie = ValideazaInformatii();

                if (materie == null)
                    return;

                if (stocareMaterii.ValideazaExistenta(materie))
                {
                    MessageBox.Show("Materia exista deja in baza de date");
                    return;
                }

                var rezultat = stocareMaterii.AddMaterie(materie);

                if (rezultat == true)
                {
                    itemAdaugat = true;
                    MessageBox.Show("Materia a fost adaugata");
                    ClearResetFormComponents.ClearInputs(panelInputs.Controls.OfType<Control>());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Materia nu a fost adaugata cu succes");
            }
        }



        #region ComboBox Events
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
            foreach (string s in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
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
            if (comboBox.Enabled == false)
            {
                comboBox.Items.Clear();
                comboBox.SelectedIndex = -1;
            }
        }

        private void comboBoxFacultate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFacultate.SelectedIndex == -1)
                return;

            comboBoxProgramStudiu.Enabled = true;
            comboBoxSpecializare.Enabled = false;
            comboBoxAn.Enabled = false;

            comboBoxProgramStudiu.Items.Clear();

            IncarcareComboBox.IncarcaProgrameStudiiFacultate(comboBoxProgramStudiu, listFacultati,
                comboBoxFacultate.SelectedItem.ToString());
        }

        private void comboBoxProgramStudiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProgramStudiu.SelectedIndex == -1)
                return;
            comboBoxSpecializare.Enabled = true;
            comboBoxAn.Enabled = false;

            comboBoxSpecializare.Items.Clear();

            IncarcareComboBox.IncarcaSpecializariFacultate(comboBoxSpecializare, listFacultati,
                comboBoxFacultate.SelectedItem.ToString(), comboBoxProgramStudiu.SelectedItem.ToString());
        }

        private void comboBoxSpecializare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSpecializare.SelectedIndex == -1)
                return;

            comboBoxAn.Enabled = true;
            comboBoxAn.Items.Clear();

            IncarcareComboBox.IncarcaAniStudent(comboBoxAn, listFacultati,
                 comboBoxFacultate.SelectedItem.ToString(), comboBoxProgramStudiu.SelectedItem.ToString(),
                 comboBoxSpecializare.SelectedItem.ToString());
        }




        #endregion

        #region Numeric UpDown
        private void numericUpCourse_ValueChanged(object sender, EventArgs e)
        {
            numericUpLaborator.Value = 100 - numericUpCurs.Value;
        }

        private void numericUpLaboratory_ValueChanged(object sender, EventArgs e)
        {
            numericUpCurs.Value = 100 - numericUpLaborator.Value;
        }



        #endregion

        #endregion


        #region Functii

        private Materie ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var denumireValida = ValidareString.ValideazaDenumireMaterie(textDenumire.Text);
                if (string.IsNullOrEmpty(denumireValida.Text))
                {
                    mesajEroare.Append($"{labelDenumire.Text} : {denumireValida.Mesaj}\n");
                    labelDenumire.ForeColor = Color.Red;
                }

                if(comboBoxSemestru.SelectedIndex == -1)
                {
                    mesajEroare.Append($"{labelSemestru.Text} Selecteaza o optiune\n");
                    labelSemestru.ForeColor = Color.Red;
                }

                if (comboBoxFacultate.SelectedIndex == -1)
                {
                    mesajEroare.Append($"{labelFacultate.Text} Selecteaza o optiune\n");
                    labelFacultate.ForeColor = Color.Red;
                }

                if (comboBoxProgramStudiu.SelectedIndex == -1)
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
                    mesajEroare.Append($"{label1.Text} Selecteaza o optiune\n");
                    label1.ForeColor = Color.Red;
                }

                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }


                var idFacultate = listFacultati.Where(f => f.Denumire == comboBoxFacultate.SelectedItem.ToString() &&
                                         f.ProgramStudiu == comboBoxProgramStudiu.SelectedItem.ToString() &&
                                         f.Specializare == comboBoxSpecializare.SelectedItem.ToString())
                            .Select(f => f.IdFacultate).FirstOrDefault();


                var anMaterie = Convert.ToInt32(comboBoxAn.SelectedItem.ToString());
                int semestru = Convert.ToInt32(comboBoxSemestru.SelectedItem);
                int procentLaborator = Convert.ToInt32(numericUpLaborator.Value);
                int procentCurs = Convert.ToInt32(numericUpCurs.Value);

                return new Materie(denumireValida.Text, anMaterie, semestru, procentLaborator, procentCurs, idFacultate);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la validarea informatiilor despre student");
            }



            return null;
        }

        #endregion

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            ClearResetFormComponents.ClearInputs(panelInputs.Controls.OfType<Control>());
            ClearResetFormComponents.ResetColors(panelInputs.Controls.OfType<Label>());

        }
    }
}
