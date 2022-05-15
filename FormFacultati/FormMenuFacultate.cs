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
        IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private const int PRIMA_COLOANA = 0;

        public FormMenuFacultate()
        {
            InitializeComponent();
            if(stocareFacultati == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxDurata, 6);
            IncarcareComboBox.IncarcaSpecializari(comboBoxProgramStudiu);
        }

        private void FormMenuFacultate_Load(object sender, EventArgs e)
        {
            IncarcaFacultati();
        }

        #region Form Events
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInitializare form = new FormInitializare();
            form.ShowDialog();
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            using (FormAdaugareFacultate form = new FormAdaugareFacultate())
            {
                form.ShowDialog();
            }
            IncarcaFacultati();
        }

        private void btnModifyFaculty_Click(object sender, EventArgs e)
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati o facultate din tabel pentru a o modifica");
                    return;
                }
                int idFacultate = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);

                Facultate facultate = stocareFacultati.GetFacultate(idFacultate);

                using (FormModificareFacultate form = new FormModificareFacultate(facultate))
                {
                    form.ShowDialog();
                }
                IncarcaFacultati();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnStergeFacultate_Click(object sender, EventArgs e)
        { 
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati o facultate din tabel pentru a o elimina");
                    return;
                }

                int idFacultate = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);

                Facultate facultate= stocareFacultati.GetFacultate(idFacultate);
                var result = stocareFacultati.DeleteFacultate(idFacultate);

                if(result == true)
                {
                    IncarcaFacultati();
                    MessageBox.Show($"Facultatea: {facultate.Denumire} - {facultate.ProgramStudiu} - {facultate.Specializare} - {facultate.Durata}" +
                        $" a fost stearsa cu succes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
