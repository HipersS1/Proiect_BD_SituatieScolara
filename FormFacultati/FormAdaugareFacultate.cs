using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace Proiect_BD_SituatieScolara
{
    public partial class FormAdaugareFacultate : Form
    {
        readonly private IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private bool itemAdaugat = false;

        public FormAdaugareFacultate()
        {
            InitializeComponent();
            IncarcareComboBox.IncarcaProgramStudiu(comboBoxProgramStudiu);
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxDurata, 6);
            IncarcareComboBox.IncarcaDenumiriFacultati(comboBoxFacultateExistenta, stocareFacultati.GetFacultati());
            comboBoxFacultateExistenta.SelectedIndex = 0;
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
                Facultate facultate = ValideazaInformatii();
                if (facultate == null)
                {
                    return;
                }
                if(stocareFacultati.ValideazaExistenta(facultate) == true)
                {
                    MessageBox.Show("Facultatea exista deja");
                    return;
                }

                var rezultat = stocareFacultati.AddFacultate(facultate);

                if(rezultat == true)
                {
                    MessageBox.Show("Facultatea a fost adaugata");
                    ClearResetFormComponents.ClearInputs(panelInputs.Controls.OfType<Control>());

                    comboBoxFacultateExistenta.SelectedIndex=0;// pentru problema cu functia de resetare a controalelor
                    itemAdaugat = true;

                    comboBoxFacultateExistenta.Items.Clear();
                    comboBoxFacultateExistenta.Items.Add("Creeaza facultate noua");
                    comboBoxFacultateExistenta.SelectedIndex=0;
                    IncarcareComboBox.IncarcaDenumiriFacultati(comboBoxFacultateExistenta, stocareFacultati.GetFacultati());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Facultatea nu a fost adaugata cu succes");
            }
        }

        private void comboBoxFacultateExistenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFacultateExistenta.SelectedIndex == -1)
                return;

            if (comboBoxFacultateExistenta.SelectedIndex == 0)
            {
                textBoxDenumire.ReadOnly = false;
                textBoxDenumire.Text = String.Empty;

            }
            else
            {
                textBoxDenumire.ReadOnly = true;
                textBoxDenumire.Text = comboBoxFacultateExistenta.SelectedItem.ToString();
            }
        }

        #endregion


        #region Validari

        /// <summary>
        /// Valideaza formularul de adaugare
        /// </summary>
        /// <returns></returns>
        private Facultate ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var denumireValida = ValidareString.ValideazaDenumire(textBoxDenumire.Text);
                if (string.IsNullOrEmpty(denumireValida.Text))
                {
                    mesajEroare.Append($"Denumire:{textBoxDenumire.Text} : {denumireValida.Mesaj}\n");
                    labelDenumire.ForeColor = Color.Red;
                }
                
                if(comboBoxProgramStudiu.SelectedItem == null)
                {
                    mesajEroare.Append($"Program Studiu: Selectati o valoare\n");
                    labelProgramStudiu.ForeColor = Color.Red;
                }

                var specializareValida = ValidareString.ValideazaDenumire(textBoxSpecializare.Text);
                if (string.IsNullOrEmpty(specializareValida.Text))
                {
                    mesajEroare.Append($"Specializare:{textBoxSpecializare.Text} : {specializareValida.Mesaj}\n");
                    labelSpecializare.ForeColor = Color.Red;
                }

                if (comboBoxDurata.SelectedItem == null)
                {
                    mesajEroare.Append($"Durata: Selectati o valoare\n");
                    labelDurata.ForeColor = Color.Red;
                }

                if(!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                return new Facultate(denumireValida.Text, comboBoxProgramStudiu.SelectedItem.ToString(), specializareValida.Text, Convert.ToInt32(comboBoxDurata.SelectedItem));
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema");
            }

            return null;
        }

        #endregion

        
    }
}
