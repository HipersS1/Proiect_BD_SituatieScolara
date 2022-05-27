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
            if(stocareStudenti == null || stocareFacultati == null)
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
            dataGridView1.CurrentCell = null;
        }
        private void FormMenuStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
            else
                this.Close();
        }

        #region Forms Events
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdaugaStudent_Click(object sender, EventArgs e)
        {
            using (FormAdaugareStudent form = new FormAdaugareStudent())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    IncarcaStudenti();
                }
            }
        }

        private void btnModificaStudent_Click(object sender, EventArgs e)
        {
            Student student = getStudentDataGrid();
            if (student == null)
            {
                return;
            }

            using (FormModificareStudent form = new FormModificareStudent(student))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    IncarcaStudenti();
                }
            }
        }
        private void btnEliminaStudent_Click(object sender, EventArgs e)
        {
            Student student = getStudentDataGrid();
            if (student == null)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini acest student?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;
            var result = stocareStudenti.DeleteStudent(student.IdStudent);

            if (result == true)
            {
                IncarcaStudenti();
                MessageBox.Show($"Studentul: {student.Nume} - {student.Prenume} a fost sters cu succes");
            }
        }

        private void btnAdaugaNote_Click(object sender, EventArgs e)
        {
            Student student = getStudentDataGrid();
            if (student == null)
            {
                return;
            }
            using (FormAdaugaNote form = new FormAdaugaNote(student))
            {
                form.ShowDialog();
            }
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            ClearResetFormComponents.ClearInputs(panelDelimiterCenter.Controls.OfType<Control>());
            IncarcaStudenti();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            try
            {
                List<SearchElement> searchElements = new List<SearchElement>();

                if (textBoxNume.Text != String.Empty)
                    searchElements.Add(new SearchElement("s.Nume", textBoxNume.Text));

                if (textBoxPrenume.Text != String.Empty)
                    searchElements.Add(new SearchElement("s.Prenume", textBoxPrenume.Text));

                if (comboBoxFacultate.SelectedItem != null)
                    searchElements.Add(new SearchElement("f.Denumire", comboBoxFacultate.SelectedItem.ToString()));

                if (comboBoxProgramStudiu.SelectedItem != null)
                    searchElements.Add(new SearchElement("f.ProgramStudiu", comboBoxProgramStudiu.SelectedItem.ToString()));

                if (comboBoxSpecializare.SelectedItem != null)
                    searchElements.Add(new SearchElement("f.Specializare", comboBoxSpecializare.SelectedItem.ToString()));

                DataSet dataSetAfisare = new DataSet();
                if (searchElements.Count > 0)
                {
                    dataSetAfisare = stocareStudenti.GetStudents(searchElements);
                }
                else
                    dataSetAfisare = stocareStudenti.GetStudentiFacultati();

                if (dataSetAfisare.Tables[0].Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Niciun rezultat gasit");
                }
                else
                    IncarcaStudentiSearch(dataSetAfisare);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #region ComboBoxEvents
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
                //IncarcareComboBox.IncarcaSpecializariFacultate(comboBoxSpecializare, listFacultati, comboBoxFacultate.SelectedItem.ToString());
            }


        }

        private void comboBoxProgramStudiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listFacultati = stocareFacultati.GetFacultati();
            comboBoxSpecializare.Items.Clear();

            if (comboBoxFacultate.SelectedIndex != -1 && comboBoxProgramStudiu.SelectedIndex != -1)
            {
                //IncarcareComboBox.IncarcaSpecializariFacultate(comboBoxSpecializare, listFacultati, comboBoxFacultate.SelectedItem.ToString(), comboBoxProgramStudiu.SelectedItem.ToString());
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

        #endregion


        #region Functii

        private void IncarcaStudenti()
        {
            try
            {
                var studenti = stocareStudenti.GetStudentiFacultati();
                IncarcareDataGridView.AfisareStudentiDataSet(dataGridView1, studenti);
                dataGridView1.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void IncarcaStudentiSearch(DataSet dataSet)
        {
            try
            {
                IncarcareDataGridView.AfisareStudentiDataSet(dataGridView1, dataSet);
                dataGridView1.CurrentCell = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private Student getStudentDataGrid()
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati un student din tabel");
                    return null;
                }

                int idStudent = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);
                return stocareStudenti.GetStudent(idStudent);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        
    }
}
