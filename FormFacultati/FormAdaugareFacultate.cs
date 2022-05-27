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
        private readonly IStocareProgrameStudii stocareProgrameStudii = (IStocareProgrameStudii)new StocareFactory().GetTipStocare(typeof(ProgramStudiu));
        private bool itemAdaugat = false;

        public FormAdaugareFacultate()
        {
            InitializeComponent();
            if (stocareFacultati == null || stocareProgrameStudii == null)
            {
                MessageBox.Show("Eroare la initializare", "Info");
            }
        }

        private void FormAdaugareFacultate_Load(object sender, EventArgs e)
        {
            IncarcareComboBox.IncarcaProgramStudiu(comboBoxProgramStudiu);
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxDurata, 6);
            comboBoxFacultateExistenta.Items.Add(new ComboItem("Creeaza facultate noua"));

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

                if(comboBoxFacultateExistenta.SelectedIndex == 0)
                {
                    ///disable textboxs

                    Facultate facultate = ValideazaInformatii();
                    if (facultate == null)
                    {
                        return;
                    }
                    if (stocareFacultati.ValideazaExistenta(facultate) == true)
                    {
                        MessageBox.Show("Facultatea exista deja", "Eroare");
                        return;
                    }

                    var rezultat = stocareFacultati.AddFacultate(facultate);

                    if (rezultat == true)
                    {
                        MessageBox.Show("Facultatea a fost adaugata");
                        ClearResetFormComponents.ClearInputs(panelInputs.Controls.OfType<Control>());

                        comboBoxFacultateExistenta.SelectedIndex = 0;// pentru problema cu functia de resetare a controalelor
                        itemAdaugat = true;

                        comboBoxFacultateExistenta.Items.Clear();
                        comboBoxFacultateExistenta.Items.Add(new ComboItem("Creeaza facultate noua"));
                        comboBoxFacultateExistenta.SelectedIndex = 0;
                        IncarcareComboBox.IncarcaDenumiriFacultati(comboBoxFacultateExistenta, stocareFacultati.GetFacultati());
                    }
                }
                else
                {
                    ComboItem facultate = comboBoxFacultateExistenta.SelectedItem as ComboItem;

                    ProgramStudiu programStudiu = ValideazaInformatiiProgramStudiu(facultate.Id);
                    if (programStudiu == null)
                    {
                        return;
                    }
                    if (stocareProgrameStudii.ValideazaExisteanta(programStudiu) == true)
                    {
                        MessageBox.Show($"Programul de studiu exista deja la facultatea {facultate.Id}", "Eroare");
                        return;
                    }

                    var result = stocareProgrameStudii.AddProgramStudiu(programStudiu);
                    if (result)
                    {
                        itemAdaugat = true;

                        MessageBox.Show($"Programul de studiu a fost adaugat la faculteatea {facultate.Text}");
                        ClearResetFormComponents.ClearInputs(panelProgramStudiu.Controls.OfType<Control>());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Problema la adaugare");
            }
        }

        #region ComboBox
        private void comboBoxFacultateExistenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFacultateExistenta.SelectedIndex == -1)
                return;

            if (comboBoxFacultateExistenta.SelectedIndex == 0)
            {
                textBoxDenumire.ReadOnly = false;
                textBoxDenumire.Text = String.Empty;
                ClearResetFormComponents.TurnOffComponents(panelProgramStudiu.Controls);
            }
            else
            {
                textBoxDenumire.ReadOnly = true;
                textBoxDenumire.Text = comboBoxFacultateExistenta.SelectedItem.ToString();
                ClearResetFormComponents.TurnOnComponents(panelProgramStudiu.Controls);
            }
        }
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
                newWidth = (int)g.MeasureString(s.Text, font).Width + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }

        #endregion

        #endregion


        #region Validari


        private ProgramStudiu ValideazaInformatiiProgramStudiu(int idFacultate)
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                if (comboBoxProgramStudiu.SelectedItem == null)
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

                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                return new ProgramStudiu(comboBoxProgramStudiu.SelectedItem.ToString(), specializareValida.Text, Convert.ToInt32(comboBoxDurata.SelectedItem), idFacultate);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la creearea programul de studiu");
            }

            return null;
        }

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
                
                if(!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                return new Facultate(denumireValida.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la creearea facultatii");
            }

            return null;
        }


        #endregion

        
    }
}
