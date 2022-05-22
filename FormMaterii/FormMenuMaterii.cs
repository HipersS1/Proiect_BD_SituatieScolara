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
    public partial class FormMenuMaterii : Form
    {
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private readonly IStocareMaterii stocareMaterii = (IStocareMaterii)new StocareFactory().GetTipStocare(typeof(Materie));
        private const int PRIMA_COLOANA = 0;
        public FormMenuMaterii()
        {
            InitializeComponent();

            //stocareMaterii.tobedeleted();

            if (stocareFacultati == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
            else
            {
                var facultateList = stocareFacultati.GetFacultati();
                IncarcareComboBox.IncarcaDenumiriFacultati(comboBoxFacultate, facultateList);
                IncarcareComboBox.IncarcaProgramStudiu(comboBoxProgramStudiu);
                IncarcareComboBox.IncarcaValoriNumerice(comboBoxAn, 6);
            }

        }

        private void FormMenuMaterii_Load(object sender, EventArgs e)
        {
            IncarcaMateriiDataSet(stocareMaterii.GetMateriiFacultati());
            comboBoxSpecializare.Enabled = false;
            comboBoxSpecializare.Items.Add("Selecteaza o facultate");
            dataGridView1.CurrentCell = null;
        }

        #region Form Events
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInitializare form = new FormInitializare();
            form.ShowDialog();
        }


        private void btnAdaguaMaterie_Click(object sender, EventArgs e)
        {
            using (FormAdaugareMaterie form = new FormAdaugareMaterie())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    IncarcaMateriiDataSet(stocareMaterii.GetMateriiFacultati());
                }
            }
        }

        private void btnModificaMaterie_Click(object sender, EventArgs e)
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati o materie din tabel");
                    return;
                }

                int idMaterie = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);
                Materie materie = stocareMaterii.GetMaterie(idMaterie);

                using (FormModificareMaterie form = new FormModificareMaterie(materie))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        IncarcaMateriiDataSet(stocareMaterii.GetMateriiFacultati());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            try
            {
                List<SearchElement> searchElements = new List<SearchElement>();

                if (textBoxDenumire.Text != String.Empty)
                    searchElements.Add(new SearchElement("m.Denumire", textBoxDenumire.Text));

                if (comboBoxAn.SelectedItem != null)
                    searchElements.Add(new SearchElement("m.An", comboBoxAn.SelectedItem.ToString()));

                if (comboBoxSemestru.SelectedItem != null)
                    searchElements.Add(new SearchElement("m.Semestru", comboBoxSemestru.SelectedItem.ToString()));

                if (comboBoxFacultate.SelectedItem != null)
                    searchElements.Add(new SearchElement("f.Denumire", comboBoxFacultate.SelectedItem.ToString()));

                if (comboBoxProgramStudiu.SelectedItem != null)
                    searchElements.Add(new SearchElement("f.ProgramStudiu", comboBoxProgramStudiu.SelectedItem.ToString()));

                if (comboBoxSpecializare.SelectedItem != null)
                    searchElements.Add(new SearchElement("f.Specializare", comboBoxSpecializare.SelectedItem.ToString()));

                DataSet dataSetAfisare = new DataSet();

                if (searchElements.Count > 0)
                {
                    dataSetAfisare = stocareMaterii.GetMateriiSearch(searchElements);
                }
                else
                    dataSetAfisare = stocareMaterii.GetMateriiFacultati();

                if (dataSetAfisare.Tables[0].Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Niciun rezultat gasit");
                }
                else
                    IncarcaMateriiDataSet(dataSetAfisare);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            ClearResetFormComponents.ClearInputs(panelDelimiterCenter.Controls.OfType<Control>());
            IncarcaMateriiDataSet(stocareMaterii.GetMateriiFacultati());
        }

        private void btnEliminaMaterie_Click(object sender, EventArgs e)
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati o materie din tabel");
                    return;
                }

                int idMaterie = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);

                Materie materie = stocareMaterii.GetMaterie(idMaterie);

                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini aceasta materie?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes)
                    return;
                var result = stocareMaterii.DeleteMaterie(idMaterie);

                if (result == true)
                {
                    IncarcaMateriiDataSet(stocareMaterii.GetMateriiFacultati());
                    MessageBox.Show($"Materia: {materie.Denumire} a fost stearsa cu succes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region ComboBox events
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


        #endregion

        #region Functii

        private void IncarcaMaterii()
        {
            try
            {
                var materii = stocareMaterii.GetMaterii();
                IncarcareDataGridView.AfisareMaterii(dataGridView1, materii);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void IncarcaMateriiDataSet(DataSet materii)
        {
            try
            {
                IncarcareDataGridView.AfisareMateriiDataSet(dataGridView1, materii);
                dataGridView1.CurrentCell = null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}

