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
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private readonly IStocareProgrameStudii stocareProgrameStudii = (IStocareProgrameStudii)new StocareFactory().GetTipStocare(typeof(ProgramStudiu));
        private const int DURATA = 6;

        private Facultate _facultate;
        private ProgramStudiu _programStudiu;
        private bool itemModificat = false;
        private bool modificareFacultate = false;
        private bool modificareProgramStudiu = false;


        public FormModificareFacultate()
        {
            InitializeComponent();
        }
        public FormModificareFacultate(Facultate facultateToBeModified)
        {
            InitializeComponent();
            if (stocareFacultati == null || stocareProgrameStudii == null)
            {
                MessageBox.Show("Eroare la initializare", "Info");
            }
            this._facultate = facultateToBeModified;
            modificareFacultate = true;
            ClearResetFormComponents.TurnOffComponents(panelProgramStudiu.Controls);
            panelProgramStudiu.Visible = false;
            IncarcaFacultate();

        }


        public FormModificareFacultate(ProgramStudiu programStudiuToBeModified)
        {
            InitializeComponent();
            if (stocareFacultati == null || stocareProgrameStudii == null)
            {
                MessageBox.Show("Eroare la initializare", "Info");
            }
            modificareProgramStudiu = true;
            this._programStudiu = programStudiuToBeModified;
            this._facultate = stocareFacultati.GetFacultate(programStudiuToBeModified.IdFacultate);

            ClearResetFormComponents.TurnOffComponents(panelFacultate.Controls);
            IncarcareComboBox.IncarcaProgramStudiu(comboBoxCiclu);
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxDurata, DURATA);
            IncarcaProgramStudiu();  
        }

        #region Form Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(itemModificat == true)
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

                if (modificareFacultate == true)
                {
                    Facultate facultate = ValideazaInformatiiFacultate();
                    if (facultate == null)
                    {
                        return;
                    }
                    if (stocareFacultati.ValideazaExistenta(facultate) == true)
                    {
                        MessageBox.Show("Facultatea exista deja");
                        return;
                    }
                    facultate.IdFacultate = _facultate.IdFacultate;
                    var rezultat = stocareFacultati.UpdateFacultate(facultate);

                    if (rezultat == true)
                    {
                        MessageBox.Show("Facultatea a fost modificata");
                        itemModificat = true;
                    }
                }
                if(modificareProgramStudiu == true)
                {
                    ProgramStudiu programStudiu = ValideazaInformatiiProgramStudiu(_programStudiu.IdFacultate);
                    if (programStudiu == null)
                    {
                        return;
                    }
                    if (stocareProgrameStudii.ValideazaExistenta(programStudiu) == true)
                    {
                        MessageBox.Show("Programul de studiu exista deja");
                        return;
                    }

                    programStudiu.IdProgramStudiu = _programStudiu.IdProgramStudiu;
                    var rezultat = stocareProgrameStudii.UpdateProgramStudiu(programStudiu);
                    if (rezultat)
                    {
                        MessageBox.Show("Programul de studiu a fost modificat");
                        itemModificat = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("A aparut o problema la procesul de modificare");
            }
        }

        #endregion


        #region Helpers

        private void IncarcaFacultate()
        {
            if (this._facultate == null)
                return;
            textBoxDenumire.Text = this._facultate.Denumire;
        }
        private void IncarcaProgramStudiu()
        {
            if (this._facultate == null)
                return;

            textBoxDenumire.Text = this._facultate.Denumire;
            comboBoxCiclu.SelectedIndex = comboBoxCiclu.FindString(_programStudiu.Ciclu);
            textBoxSpecializare.Text = this._programStudiu.Specializare;
            comboBoxDurata.SelectedIndex = comboBoxDurata.FindString(_programStudiu.Durata.ToString());
        }

        private Facultate ValideazaInformatiiFacultate()
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

                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                return new Facultate(denumireValida.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema");
            }

            return null;
        }


        private ProgramStudiu ValideazaInformatiiProgramStudiu(int idFacultate)
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                if (comboBoxCiclu.SelectedItem == null)
                {
                    mesajEroare.Append($"Ciclu: Selectati o valoare\n");
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

                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                return new ProgramStudiu(comboBoxCiclu.SelectedItem.ToString(), specializareValida.Text, Convert.ToInt32(comboBoxDurata.SelectedItem), idFacultate);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la creearea programul de studiu");
            }

            return null;
        }


        #endregion
    }
}
