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
        private readonly IStocareMaterii stocareMaterii = (IStocareMaterii)new StocareFactory().GetTipStocare(typeof(Materie));
        private const int PRIMA_COLOANA = 0;
        private const int MAXANI = 6;
        private readonly FormWindowState windowState;

        public FormMenuMaterii(FormWindowState windowState)
        {
            InitializeComponent();
            this.windowState = windowState;
            if (stocareMaterii == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void FormMenuMaterii_Load(object sender, EventArgs e)
        {
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxAn, MAXANI);
            IncarcaMaterii();
            dataGridView1.CurrentCell = null;
            this.WindowState = windowState;

        }

        private void FormMenuMaterii_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
            else
                this.Close();
        }

        #region Form Events

        #region Butoane stanga
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdaguaMaterie_Click(object sender, EventArgs e)
        {
            using (FormAdaugareMaterie form = new FormAdaugareMaterie())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    IncarcaMaterii();
                }
            }
        }

        private void btnModificaMaterie_Click(object sender, EventArgs e)
        {
            Materie materie = getMaterieDataGrid();
            if (materie == null)
                return;
            using (FormModificareMaterie form = new FormModificareMaterie(materie))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    IncarcaMaterii();
                }
            }

        }
        private void btnEliminaMaterie_Click(object sender, EventArgs e)
        {
            Materie materie = getMaterieDataGrid();
            if (materie == null)
                return;

            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini aceasta materie?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;
            var result = stocareMaterii.DeleteMaterie(materie.IdMaterie);

            if (result == true)
            {
                IncarcaMaterii();
                MessageBox.Show($"Materia: {materie.Denumire} a fost stearsa cu succes");
            }
        }
        #endregion


        #region Butoane centru
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            ClearResetFormComponents.ClearInputs(panelDelimiterCenter.Controls.OfType<Control>());
            IncarcaMaterii();
        }


        private void btnCauta_Click(object sender, EventArgs e)
        {
            try
            {
                List<SearchElement> searchElements = new List<SearchElement>();

                if (textBoxDenumire.Text != String.Empty)
                    searchElements.Add(new SearchElement("Denumire", textBoxDenumire.Text));

                if (comboBoxAn.SelectedItem != null)
                    searchElements.Add(new SearchElement("An", comboBoxAn.SelectedItem.ToString()));

                if (comboBoxSemestru.SelectedItem != null)
                    searchElements.Add(new SearchElement("Semestru", comboBoxSemestru.SelectedItem.ToString()));

                List<Materie> listaMateriiAfisare;

                if (searchElements.Count > 0)
                {
                    listaMateriiAfisare = stocareMaterii.GetMateriiSearch(searchElements);
                }
                else
                    listaMateriiAfisare = stocareMaterii.GetMaterii();

                if (listaMateriiAfisare.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Niciun rezultat gasit");
                }
                else
                    IncarcaMaterii(listaMateriiAfisare);
            }
            catch (Exception ex)
            {
                throw;
            }
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
        private void IncarcaMaterii(List<Materie> listaAfisare)
        {
            try
            {
                IncarcareDataGridView.AfisareMaterii(dataGridView1, listaAfisare);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Materie getMaterieDataGrid()
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati o materie din tabel");
                    return null;
                }

                int idMaterie = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);
                return stocareMaterii.GetMaterie(idMaterie);
            }
            catch (Exception)
            {   
                throw;
            }

        }


        #endregion

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            labelNumarElemente.Text = $"Nr.Elemente: {dataGridView1.RowCount}";
            dataGridView1.CurrentCell = null;
        }
    }
}

