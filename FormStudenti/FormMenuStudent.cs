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
        private readonly IStocareProgrameStudii stocareProgrameStudii = (IStocareProgrameStudii)new StocareFactory().GetTipStocare(typeof(ProgramStudiu));
        private const int PRIMA_COLOANA = 0;
        private List<Facultate> listaFacultati;
        private List<ProgramStudiu> listaProgrameStudii;
        private readonly FormWindowState windowState;


        public FormMenuStudent(FormWindowState windowState)
        {
            InitializeComponent();
            this.windowState = windowState;

            if(stocareStudenti == null || stocareFacultati == null || stocareProgrameStudii == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
            else
            {
                listaFacultati = stocareFacultati.GetFacultati();
                listaProgrameStudii = stocareProgrameStudii.GetProgrameStudii();
            }

        }
        private void FormMenuStudent_Load(object sender, EventArgs e)
        {
            comboBoxSpecializare.Enabled = false;
            comboBoxSpecializare.Items.Add("Selecteaza o facultate");
            IncarcaStudenti();
            IncarcareComboBox.IncarcaDenumiriFacultati(comboBoxFacultate, listaFacultati);
            IncarcareComboBox.IncarcaProgramStudiu(comboBoxCicluStudiu);
            comboBoxSpecializare.Items.Add(new ComboItem("Selecteaza o facultate"));
            comboBoxSpecializare.SelectedIndex = 0;
            dataGridView1.CurrentCell = null;

            this.WindowState = windowState;

        }
        private void FormMenuStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
            else
                this.Close();
        }

        #region Forms Events

        #region Butoane Stanga
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
            Facultate facultate = getFacultateDataGrid();
            ProgramStudiu programStudiu = getProgramStudiuDataGrid();
            if (student == null )
            {
                return;
            }

            using (FormModificareStudent form = new FormModificareStudent(student,facultate, programStudiu))
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
            Facultate facultate = getFacultateDataGrid();
            ProgramStudiu programStudiu = getProgramStudiuDataGrid();
            if (student == null)
            {
                return;
            }
            using (FormAdaugaNote form = new FormAdaugaNote(student, facultate, programStudiu))
            {
                form.ShowDialog();
            }
        }



        #endregion

        #region Butoane centru

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            ClearResetFormComponents.ClearInputs(panelDelimiterCenter.Controls.OfType<Control>());
            IncarcaStudenti();
            comboBoxSpecializare.Items.Clear();
            comboBoxSpecializare.Items.Add(new ComboItem("Selecteaza o facultate"));
            comboBoxSpecializare.SelectedIndex = 0;
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

                if (comboBoxCicluStudiu.SelectedItem != null)
                    searchElements.Add(new SearchElement("p.Ciclu", comboBoxCicluStudiu.SelectedItem.ToString()));

                if (comboBoxSpecializare.SelectedItem != null)
                    searchElements.Add(new SearchElement("p.Specializare", comboBoxSpecializare.SelectedItem.ToString()));

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

        #endregion

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
            comboBoxCicluStudiu.SelectedIndex = -1;

            if (comboBoxFacultate.SelectedIndex != -1)
            {
                IncarcareComboBox.IncarcaSpecializariFacultate(comboBoxSpecializare, listaProgrameStudii, ((ComboItem)comboBoxFacultate.SelectedItem).Id);
            }
        }

        private void comboBoxProgramStudiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listFacultati = stocareFacultati.GetFacultati();
            comboBoxSpecializare.Items.Clear();

            if (comboBoxFacultate.SelectedIndex != -1 && comboBoxCicluStudiu.SelectedIndex != -1)
            {
                IncarcareComboBox.IncarcaSpecializariFacultate(comboBoxSpecializare, listaProgrameStudii, ((ComboItem)comboBoxFacultate.SelectedItem).Id, ((ComboItem)comboBoxCicluStudiu.SelectedItem).Text);
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
                newWidth = (int)g.MeasureString(s.Text, font).Width
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

        private Facultate getFacultateDataGrid()
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    return null;
                }

                int idFacultate = Convert.ToInt32(dataGridView1["IdFacultate", currentCell.RowIndex].Value);
                return stocareFacultati.GetFacultate(idFacultate);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private ProgramStudiu getProgramStudiuDataGrid()
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    return null;
                }

                int idProgram = Convert.ToInt32(dataGridView1["IdProgramStudiu", currentCell.RowIndex].Value);
                return stocareProgrameStudii.GetProgramStudiu(idProgram);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion


    }
}
