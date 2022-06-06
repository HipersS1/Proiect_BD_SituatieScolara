using LibrarieModele;
using NivelAccesDate;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proiect_BD_SituatieScolara
{
    public partial class FormModificareMaterie : Form
    {
        private readonly IStocareMaterii stocareMaterii = (IStocareMaterii)new StocareFactory().GetTipStocare(typeof(Materie));
        private Materie materieToBeModified;
        private bool itemModificat = false;
        private const int MAXAN = 6;
        private const int SEMESTRU = 2;

        public FormModificareMaterie(Materie materie)
        {
            InitializeComponent();
            materieToBeModified = materie;
        }
        private void FormModificareMaterie_Load(object sender, EventArgs e)
        {
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxAn, MAXAN);
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxSemestru, SEMESTRU);
            numericUpLaborator.Value = materieToBeModified.ProcentLaborator;
            comboBoxAn.SelectedIndex = materieToBeModified.An - 1;
            comboBoxSemestru.SelectedIndex = materieToBeModified.Semestru - 1;
        }


        #region Form events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (itemModificat == true)
                this.DialogResult = DialogResult.OK;
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


                if (stocareMaterii.ValideazaExistenta(materie) && numericUpCurs.Value == materieToBeModified.ProcentCurs)
                {
                    MessageBox.Show("Materia exista deja");
                    return;
                }

                var rezultat = stocareMaterii.UpdateMaterie(materie);

                if (rezultat == true)
                {
                    MessageBox.Show("Materia a fost modificata");
                    itemModificat = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Studentul nu a fost adaugat cu succes");
            }
        }

        #region NumericUpDown
        private void numericUpCourse_ValueChanged(object sender, EventArgs e)
        {
            numericUpLaborator.Value = 100 - numericUpCurs.Value ;
        }

        private void numericUpLaboratory_ValueChanged(object sender, EventArgs e)
        {
            numericUpCurs.Value = 100 - numericUpLaborator.Value;
        }
        #endregion

        #region Placeholders

        private void textBoxPlaceholder_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox == textBoxDenumire && textBox.Text == materieToBeModified.Denumire)
            {
                textBox.Text = "";
            }

        }
        private void textBoxPlaceholder_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (String.IsNullOrEmpty(textBox.Text))
            {
                if (textBox == textBoxDenumire)
                {
                    textBox.Text = materieToBeModified.Denumire;
                }
            }
        }
        #endregion

        #endregion


        #region Functii

        private Materie ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var denumireValida = ValidareString.ValideazaDenumireMaterie(textBoxDenumire.Text);
                if (string.IsNullOrEmpty(denumireValida.Text))
                {
                    mesajEroare.Append($"{labelDenumire.Text} : {denumireValida.Mesaj}\n");
                    labelDenumire.ForeColor = Color.Red;
                }

                if (comboBoxSemestru.SelectedIndex == -1)
                {
                    mesajEroare.Append($"{labelSemestru.Text} Selecteaza o optiune\n");
                    labelSemestru.ForeColor = Color.Red;
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

                var anMaterie = Convert.ToInt32(comboBoxAn.SelectedItem.ToString());
                int semestru = Convert.ToInt32(comboBoxSemestru.SelectedItem);
                int procentLaborator = Convert.ToInt32(numericUpLaborator.Value);
                int procentCurs = Convert.ToInt32(numericUpCurs.Value);

                return new Materie(denumireValida.Text, anMaterie, semestru, procentLaborator, procentCurs, materieToBeModified.IdMaterie);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la validarea informatiilor");
            }

            return null;
        }


        #endregion


    }
}
