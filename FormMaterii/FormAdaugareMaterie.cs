using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace Proiect_BD_SituatieScolara
{
    public partial class FormAdaugareMaterie : Form
    {
        private readonly IStocareMaterii stocareMaterii = (IStocareMaterii)new StocareFactory().GetTipStocare(typeof(Materie));
        private bool itemAdaugat = false;
        private const int MAXAN = 6;

        public FormAdaugareMaterie()
        {
            InitializeComponent();
        }

        private void FormAdaugareMaterie_Load(object sender, EventArgs e)
        {
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxAn, MAXAN);
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

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            ClearResetFormComponents.ClearInputs(panelInputs.Controls.OfType<Control>());
            ClearResetFormComponents.ResetColors(panelInputs.Controls.OfType<Label>());
        }

        #region ComboBox Events
        private void comboBox_EnabledChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.Enabled == false)
            {
                comboBox.Items.Clear();
                comboBox.SelectedIndex = -1;
            }
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

                if (comboBoxSemestru.SelectedIndex == -1)
                {
                    mesajEroare.Append($"{labelSemestru.Text} Selecteaza o optiune\n");
                    labelSemestru.ForeColor = Color.Red;
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


                var anMaterie = Convert.ToInt32(comboBoxAn.SelectedItem.ToString());
                int semestru = Convert.ToInt32(comboBoxSemestru.SelectedItem);
                int procentLaborator = Convert.ToInt32(numericUpLaborator.Value);
                int procentCurs = Convert.ToInt32(numericUpCurs.Value);

                return new Materie(denumireValida.Text, anMaterie, semestru, procentLaborator, procentCurs);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la validarea informatiilor despre materie");
            }
            return null;
        }

        #endregion

        
    }
}
