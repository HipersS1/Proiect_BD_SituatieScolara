using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace Proiect_BD_SituatieScolara
{
    public partial class FormMenuFacultate : Form
    {
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private const int PRIMA_COLOANA = 0;
        
        public FormMenuFacultate()
        {
            InitializeComponent();
            if(stocareFacultati == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void FormMenuFacultate_Load(object sender, EventArgs e)
        {
            IncarcaFacultati();
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxDurata, 6);
            IncarcareComboBox.IncarcaProgramStudiu(comboBoxProgramStudiu);
        }
        private void FormMenuFacultate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
            else
                this.Close();
        }

        #region Form Events
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            ClearResetFormComponents.ClearInputs(panelDelimiterCenter.Controls.OfType<Control>());
            IncarcaFacultati();

        }
        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            using (FormAdaugareFacultate form = new FormAdaugareFacultate())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    IncarcaFacultati();
                }
            }
        }

        private void btnModifyFaculty_Click(object sender, EventArgs e)
        {
            Facultate facultate = GetFacultateDataGrid();
            if (facultate == null) 
                return;

            using (FormModificareFacultate form = new FormModificareFacultate(facultate))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    IncarcaFacultati();
                }
            }
        }

        private void btnStergeFacultate_Click(object sender, EventArgs e)
        {
            Facultate facultate = GetFacultateDataGrid();
            if (facultate == null) return;

            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini facultatea?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;
            var result = stocareFacultati.DeleteFacultate(facultate.IdFacultate);

            if(result == true)
            {
                IncarcaFacultati();
                MessageBox.Show($"Facultatea: {facultate.Denumire} - {facultate.ProgramStudiu} - {facultate.Specializare} - {facultate.Durata}" +
                    $" a fost stearsa cu succes");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<SearchElement> searchElements = new List<SearchElement>();

                if(textBoxDenumire.Text != String.Empty)
                    searchElements.Add(new SearchElement(labelDenumire.Text, textBoxDenumire.Text));
                
                if (textBoxSpecializare.Text != String.Empty)
                    searchElements.Add(new SearchElement(labelSpecializare.Text, textBoxSpecializare.Text));

                if (comboBoxProgramStudiu.SelectedItem != null)
                    searchElements.Add(new SearchElement(labelProgramStudiu.Text.Replace(" ", ""), comboBoxProgramStudiu.SelectedItem.ToString()));

                if(comboBoxDurata.SelectedItem != null)
                    searchElements.Add(new SearchElement(labelDurata.Text, comboBoxDurata.SelectedItem.ToString()));

                List<Facultate> facultati;
                if(searchElements.Count > 0)
                {
                    facultati = stocareFacultati.GetFacultati(searchElements);
                    comboBoxProgramStudiu.SelectedItem = null;
                    comboBoxDurata.SelectedItem = null;
                }
                else
                    facultati = stocareFacultati.GetFacultati();

                if (facultati.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Niciun rezultat gasit");
                }
                else
                    IncarcareDataGridView.AfisareFacultati(dataGridView1, facultati);

            }
            catch (Exception ex)
            {
                throw;
            }
        }


        #endregion


        #region Functii
        private void IncarcaFacultati()
        {
            try
            {
                var facultati = stocareFacultati.GetFacultati();
                IncarcareDataGridView.AfisareFacultati(dataGridView1, facultati);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private Facultate GetFacultateDataGrid()
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati o facultate din tabel pentru a o modifica");
                    return null;
                }
                int idFacultate = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);

                return stocareFacultati.GetFacultate(idFacultate);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}
