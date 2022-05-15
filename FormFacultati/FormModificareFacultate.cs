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
    public partial class FormModificareFacultate : Form
    {
        private Facultate _facultate;
        IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));

        public FormModificareFacultate()
        {
            InitializeComponent();
        }
        public FormModificareFacultate(Facultate facultateToBeModified)
        {
            InitializeComponent();
            this._facultate = facultateToBeModified;
            IncarcareComboBox.IncarcaSpecializari(comboBoxProgramStudiu);
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxDurata, 6);
            IncarcaFacultate();
        }

        #region Form Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
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

                facultate.IdFacultate = _facultate.IdFacultate;
                var rezultat = stocareFacultati.UpdateFacultate(facultate);

                if (rezultat == true)
                {
                    MessageBox.Show("Facultatea a fost modificata");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Facultatea nu a fost modificata cu succes");
            }
        }

        #endregion


        #region Helpers

        private void IncarcaFacultate()
        {
            if (this._facultate == null)
                return;

            textBoxDenumire.Text = this._facultate.Denumire;
            textBoxSpecializare.Text = this._facultate.Specializare;
            comboBoxProgramStudiu.SelectedItem = this._facultate.ProgramStudiu;
            comboBoxDurata.SelectedItem = this._facultate.Durata;
        }

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

                var specializareValida = ValidareString.ValideazaDenumire(textBoxSpecializare.Text);
                if (string.IsNullOrEmpty(specializareValida.Text))
                {
                    mesajEroare.Append($"Specializare:{textBoxSpecializare.Text} : {specializareValida.Mesaj}\n");
                    labelSpecializare.ForeColor = Color.Red;
                }

                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
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
