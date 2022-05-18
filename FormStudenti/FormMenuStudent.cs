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
    public partial class FormMenuStudent : Form
    {
        private readonly IStocareStudenti stocareStudenti= (IStocareStudenti)new StocareFactory().GetTipStocare(typeof(Student));
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private const int PRIMA_COLOANA = 0;

        public FormMenuStudent()
        {
            InitializeComponent();
            if(stocareStudenti == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
            else
            {
                var facultateList = stocareFacultati.GetFacultati();
                IncarcaStudenti();
                IncarcareComboBox.IncarcaDenumiriFacultati(comboBoxFacultate, facultateList);
                IncarcareComboBox.IncarcaProgramStudiu(comboBoxProgramStudiu);
            }
        }
        private void FormMenuStudent_Load(object sender, EventArgs e)
        {
            comboBoxSpecializare.Enabled = false;
            comboBoxSpecializare.Items.Add("Selecteaza o facultate");
        }


        #region Forms Events
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInitializare form = new FormInitializare();
            form.ShowDialog();
        }

        private void btnAdaugaStudent_Click(object sender, EventArgs e)
        {
            using (FormAdaugareStudent form = new FormAdaugareStudent())
            {
                form.ShowDialog();
            }
        }

        private void btnModificaStudent_Click(object sender, EventArgs e)
        {
            using (FormModificareStudent form = new FormModificareStudent())
            {
                form.ShowDialog();
            }
        }

        private void btnAdaugaNote_Click(object sender, EventArgs e)
        {
            using (FormAdaugaNote form = new FormAdaugaNote())
            {
                form.ShowDialog();
            }
        }

        private void comboBoxFacultate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFacultate.SelectedIndex == -1)
            {
                comboBoxSpecializare.Enabled = false;
                return;
            }

            var listFacultati = stocareFacultati.GetFacultati();
            comboBoxSpecializare.Enabled = true;
            comboBoxSpecializare.Items.Clear();
            comboBoxProgramStudiu.SelectedIndex = -1;

            if (comboBoxFacultate.SelectedIndex != -1)
            {
                IncarcareComboBox.IncarcaSpecializariFacultate(comboBoxSpecializare, listFacultati, comboBoxFacultate.SelectedItem.ToString());
            }


        }

        private void comboBoxProgramStudiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listFacultati = stocareFacultati.GetFacultati();
            comboBoxSpecializare.Items.Clear();

            if (comboBoxFacultate.SelectedIndex != -1 && comboBoxProgramStudiu.SelectedIndex != -1)
            {
                IncarcareComboBox.IncarcaSpecializariFacultate(comboBoxSpecializare, listFacultati, comboBoxFacultate.SelectedItem.ToString(), comboBoxProgramStudiu.SelectedItem.ToString());
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

        #endregion


        #region Functii

        private void IncarcaStudenti()
        {
            try
            {
                var studenti = stocareStudenti.GetStudents();
                IncarcareDataGridView.AfisareStudenti(dataGridView1, studenti);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        #endregion

        
    }
}
