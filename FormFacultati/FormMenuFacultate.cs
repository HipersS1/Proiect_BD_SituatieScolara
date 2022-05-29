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
        private readonly IStocareProgrameStudii stocareProgrameStudii = (IStocareProgrameStudii)new StocareFactory().GetTipStocare(typeof(ProgramStudiu));
        private readonly IStocareProgramStudiuMaterie stocareMateriiProgramStudiu = (IStocareProgramStudiuMaterie)new StocareFactory().GetTipStocare(typeof(ProgramStudiuMaterie));
        private const int PRIMA_COLOANA = 0;
        private readonly FormWindowState windowState;

        private Facultate facultateCurenta;
        private ProgramStudiu programStudiuCurent;
        bool tabelActivFacultate = false;
        bool tabelActivPrograme = false;
        bool tabelActivMaterii = false;
        
        public FormMenuFacultate(FormWindowState windowState)
        {
            InitializeComponent();
            this.windowState = windowState;
            if(stocareFacultati == null || stocareProgrameStudii == null || stocareMateriiProgramStudiu == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void FormMenuFacultate_Load(object sender, EventArgs e)
        {
            IncarcaFacultati();
            tabelActivFacultate=true;
            labelCampNume.Text = "Denumire";
            IncarcareComboBox.IncarcaValoriNumerice(comboBoxDurata, 6);
            IncarcareComboBox.IncarcaProgramStudiu(comboBoxCicluStudiu);
            buttonVizualizeazaPrograme.Text = "Vizualizeaza programe";
            this.WindowState = windowState;

        }
        private void FormMenuFacultate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
            else
                this.Close();
        }

        #region Form Events

        private void buttonVizualizeazaPrograme_Click(object sender, EventArgs e)
        {
            if (tabelActivFacultate)
            {
                facultateCurenta = GetFacultateDataGrid();
                if (facultateCurenta == null)
                {
                    return;
                }
                labelMenuHeader.Text = $"{facultateCurenta.Denumire} ";
                tabelActivFacultate = false;
                tabelActivPrograme = true;
                labelCampNume.Text = "Specializare";
                buttonVizualizeazaPrograme.Text = "Vizualizeaza facultati";
                buttonVizualizeazaMaterii.Text = "Vizualizeaza materii";
                buttonVizualizeazaMaterii.Visible = true;
                IncarcaProgrameStudii(facultateCurenta.IdFacultate);
                
            }
            else if (tabelActivPrograme || tabelActivMaterii)
            {
                tabelActivFacultate = true;
                tabelActivPrograme = false;
                facultateCurenta = null;

                labelMenuHeader.Text = String.Empty;
                labelCampNume.Text = "Denumire";
                buttonVizualizeazaPrograme.Text = "Vizualizeaza programe";
                // Show
                buttonVizualizeazaMaterii.Visible = false;
                if (tabelActivMaterii)
                {
                    tabelActivMaterii = false;
                    buttonClearSearch.Visible = true;
                    btnSearch.Visible = true;
                    labelCampNume.Visible = true;
                    textBoxCampNume.Visible = true;
                }
                IncarcaFacultati();
            }

        }

        private void buttonVizualizeazaMaterii_Click(object sender, EventArgs e)
        {
            if(tabelActivPrograme)
            {
                programStudiuCurent = GetProgramStudiuDataGrid();
                if (programStudiuCurent == null) return;

                tabelActivPrograme = false;
                tabelActivMaterii = true;
                labelMenuHeader.Text = $"{facultateCurenta.Denumire}\n{programStudiuCurent.Ciclu} {programStudiuCurent.Specializare}";
                buttonVizualizeazaMaterii.Text = "Vizualizeaza Programe";
                buttonVizualizeazaMaterii.Visible = true;
                buttonClearSearch.Visible = false;
                btnSearch.Visible = false;
                IncarcaMateriiProgramStudiu(programStudiuCurent.IdProgramStudiu);
            }
            else if (tabelActivMaterii)
            {
                programStudiuCurent = null;
                tabelActivPrograme = true;
                tabelActivMaterii = false;
                labelMenuHeader.Text = $"{facultateCurenta.Denumire}\n";
                buttonVizualizeazaMaterii.Text = "Vizualizeaza Materii";
                // Show
                labelCampNume.Visible = true;
                textBoxCampNume.Visible = true;
                buttonVizualizeazaMaterii.Visible = true;
                buttonClearSearch.Visible = true;
                btnSearch.Visible = true;
                IncarcaProgrameStudii(facultateCurenta.IdFacultate);
            }
 
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            ClearResetFormComponents.ClearInputs(panelDelimiterCenter.Controls.OfType<Control>());
            if (tabelActivFacultate)
            {
                IncarcaFacultati();
            }
            if (tabelActivPrograme)
            {
                IncarcaProgrameStudii(facultateCurenta.IdFacultate);
            }
            dataGridView1.CurrentCell = null;

        }
        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            if (tabelActivMaterii)
            {
                using (FormAdaugareMateriiProgramStudiu form = new FormAdaugareMateriiProgramStudiu(programStudiuCurent, facultateCurenta))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        IncarcaMateriiProgramStudiu(programStudiuCurent.IdProgramStudiu);
                    }
                }
                return;
            }

            using (FormAdaugareFacultate form = new FormAdaugareFacultate())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    if (tabelActivFacultate)
                    {
                        IncarcaFacultati();
                    }
                    if (tabelActivPrograme)
                    {
                        IncarcaProgrameStudii(facultateCurenta.IdFacultate);
                    }
                }
            }
        }

        private void btnModifyFaculty_Click(object sender, EventArgs e)
        {
            if (tabelActivFacultate)
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

            if (tabelActivPrograme)
            {
                ProgramStudiu programStudiu = GetProgramStudiuDataGrid();
                if (programStudiu == null) return;
                using (FormModificareFacultate form = new FormModificareFacultate(programStudiu))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        IncarcaProgrameStudii(programStudiu.IdFacultate);
                    }
                }
            }
            
        }

        private void btnStergeFacultate_Click(object sender, EventArgs e)
        {
            if (tabelActivFacultate)
            {
                Facultate facultate = GetFacultateDataGrid();
                if (facultate == null) return;

                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini facultatea?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes)
                    return;

                var resultPrograme = stocareProgrameStudii.DeleteProgrameStudii(facultate.IdFacultate);
                var result = stocareFacultati.DeleteFacultate(facultate.IdFacultate);

                if (result == true)
                {
                    IncarcaFacultati();
                    MessageBox.Show($"Facultatea: {facultate.Denumire} a fost stearsa cu succes");
                }
                
            }

            if (tabelActivPrograme)
            {
                ProgramStudiu programStudiu = GetProgramStudiuDataGrid();
                if (programStudiu == null) return;

                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini programul de studiu?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes)
                    return;
                var result = stocareProgrameStudii.DeleteProgramStudiu(programStudiu.IdProgramStudiu);

                if (result == true)
                {
                    IncarcaProgrameStudii(programStudiu.IdFacultate);
                    MessageBox.Show($"Programul de studiu : {programStudiu.Ciclu} {programStudiu.Specializare} a fost sters cu succes");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                List<SearchElement> searchElements = new List<SearchElement>();

                // Aici se gaseste si denumiera facultatii dar si specializarea programului de studiu
                if (textBoxCampNume.Text != String.Empty)
                    searchElements.Add(new SearchElement(labelCampNume.Text, textBoxCampNume.Text));

                if (tabelActivFacultate)
                {
                    List<Facultate> facultati;
                    if (searchElements.Count > 0)
                    {
                        facultati = stocareFacultati.GetFacultati(searchElements);
                    }
                    else
                        facultati = stocareFacultati.GetFacultati();

                    if (facultati.Count == 0)
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Niciun rezultat gasit");
                    }
                    else
                    {
                        IncarcareDataGridView.AfisareFacultati(dataGridView1, facultati);

                    }
                }

                if (tabelActivPrograme)
                {
                    List<ProgramStudiu> programeStudii;
                    if (comboBoxCicluStudiu.SelectedItem != null)
                        searchElements.Add(new SearchElement("Ciclu", comboBoxCicluStudiu.SelectedItem.ToString()));

                    if (comboBoxDurata.SelectedItem != null)
                        searchElements.Add(new SearchElement(labelDurata.Text, comboBoxDurata.SelectedItem.ToString()));

                    searchElements.Add(new SearchElement("IdFacultate", facultateCurenta.IdFacultate.ToString()));

                    if (searchElements.Count > 1)
                    {
                        programeStudii = stocareProgrameStudii.GetProgrameStudii(searchElements);
                    }
                    else
                        programeStudii = stocareProgrameStudii.GetProgrameStudii();

                    if (programeStudii.Count == 0)
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Niciun rezultat gasit");
                    }
                    else
                    {
                        IncarcareDataGridView.AfisareProgrameStudii(dataGridView1, programeStudii, facultateCurenta.IdFacultate);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion


        #region Functii

        #region Afisare
        private void IncarcaFacultati()
        {
            try
            {
                dataGridView1.DataSource = null;
                labelCicluStudiu.Visible = false;
                comboBoxCicluStudiu.Visible=false;
                labelDurata.Visible = false;
                comboBoxDurata.Visible = false;
                var facultati = stocareFacultati.GetFacultati();
                IncarcareDataGridView.AfisareFacultati(dataGridView1, facultati);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void IncarcaProgrameStudii(int idFacultate)
        {
            try
            {
                dataGridView1.DataSource = null;
                labelCicluStudiu.Visible = true;
                comboBoxCicluStudiu.Visible = true;
                labelDurata.Visible = true;
                comboBoxDurata.Visible = true;
                var programeStudii = stocareProgrameStudii.GetProgrameStudii();
                IncarcareDataGridView.AfisareProgrameStudii(dataGridView1, programeStudii, idFacultate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void IncarcaMateriiProgramStudiu(int idProgramStudiu)
        {
            try
            {
                dataGridView1.DataSource = null;
                labelCicluStudiu.Visible = false;
                comboBoxCicluStudiu.Visible = false;
                labelDurata.Visible = false;
                comboBoxDurata.Visible = false;
                labelCampNume.Visible = false;
                textBoxCampNume.Visible = false;
                IncarcareDataGridView.AfisareMateriiProgramStudiu(dataGridView1, stocareMateriiProgramStudiu.GetDetaliiMateriiProgramStudiu(idProgramStudiu));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        #endregion
        private Facultate GetFacultateDataGrid()
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati o facultate din tabel");
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
        private ProgramStudiu GetProgramStudiuDataGrid()
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati un program de studiu din tabel");
                    return null;
                }
                int idProgram = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);

                return stocareProgrameStudii.GetProgramStudiu(idProgram);
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
