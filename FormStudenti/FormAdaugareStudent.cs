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
        private const int PRIMA_COLOANA = 0;


        public FormAdaugareStudent()
        {
            InitializeComponent();
            var facultati = stocareFacultati.GetFacultati();
            IncarcareComboBox.IncarcaDenumiriFacultati(comboBoxFacultate, facultati);
        }

        #region Form events

        #region Form

        private void FormAdaugareStudent_Load(object sender, EventArgs e)
        {
            comboBoxProgramStudiu.Enabled = false;
            comboBoxSpecializare.Enabled = false;
            comboBoxAn.Enabled = false;
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            try
            {
                ClearResetFormComponents.ResetColors(panelInputs.Controls.OfType<Label>());
                //Student student = ValideazaInformatii();
                //if (student == null)
                //{
                //    return;
                //}

                //if (stocareFacultati.ValideazaExistenta(student) == true)
                //{
                //    MessageBox.Show("Facultatea exista deja");
                //    return;
                //}

                //var rezultat = stocareStudenti.AddStudent(student);

                //if (rezultat == true)
                //{
                //    MessageBox.Show("Facultatea a fost adaugata");
                //    ClearResetFormComponents.ClearInputs(panelInputs.Controls.OfType<Control>());
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Facultatea nu a fost adaugata cu succes");
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
            if(comboBox.Enabled == false)
            {
                comboBox.Items.Clear();
                comboBox.SelectedIndex = -1;
            }
        }

        private void comboBoxFacultate_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProgramStudiu.Enabled = true;
            comboBoxSpecializare.Enabled = false;
            comboBoxAn.Enabled = false;

            comboBoxProgramStudiu.Items.Clear();

            var facultati = stocareFacultati.GetFacultati();
            IncarcareComboBox.IncarcaProgrameStudiiFacultate(comboBoxProgramStudiu, facultati, 
                comboBoxFacultate.SelectedItem.ToString());
        }

        private void comboBoxProgramStudiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSpecializare.Enabled = true;
            comboBoxAn.Enabled=false;

            comboBoxSpecializare.Items.Clear();

            var facultati = stocareFacultati.GetFacultati();
            IncarcareComboBox.IncarcaSpecializariFacultate(comboBoxSpecializare, facultati,
                comboBoxFacultate.SelectedItem.ToString(), comboBoxProgramStudiu.SelectedItem.ToString());
        }
        private void comboBoxSpecializare_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAn.Enabled = true;
            comboBoxAn.Items.Clear();


            var facultati = stocareFacultati.GetFacultati();
            IncarcareComboBox.IncarcaAniStudent(comboBoxAn, facultati,
                 comboBoxFacultate.SelectedItem.ToString(), comboBoxProgramStudiu.SelectedItem.ToString(),
                 comboBoxSpecializare.SelectedItem.ToString());

        }



        #endregion

        #endregion


        
    }
}
