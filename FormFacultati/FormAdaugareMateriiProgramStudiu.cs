using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace Proiect_BD_SituatieScolara
{
    public partial class FormAdaugareMateriiProgramStudiu : Form
    {
        readonly private IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        readonly private IStocareMaterii stocareMaterii = (IStocareMaterii)new StocareFactory().GetTipStocare(typeof(Materie));
        private readonly IStocareProgrameStudii stocareProgrameStudii = (IStocareProgrameStudii)new StocareFactory().GetTipStocare(typeof(ProgramStudiu));
        private readonly IStocareProgramStudiuMaterie stocareMateriiProgramStudiu = (IStocareProgramStudiuMaterie)new StocareFactory().GetTipStocare(typeof(ProgramStudiuMaterie));
        private ProgramStudiu programStudiuCurent;
        private Facultate facultateCurenta;
        private DataSet materiiProgramStudiuCurent;
        private DataSet materiiBD;
        private bool itemAdaugat = false;
        private const int PRIMA_COLOANA = 0;

        //
        private const int WIDTHNUME = 190;


        public FormAdaugareMateriiProgramStudiu(ProgramStudiu programStudiu, Facultate facultate)
        {
            InitializeComponent();
            if (stocareFacultati == null || stocareProgrameStudii == null || stocareMateriiProgramStudiu == null)
            {
                MessageBox.Show("Eroare la initializare", "Info");
            }
            else
            {
                programStudiuCurent = programStudiu;
                facultateCurenta = facultate;
                materiiProgramStudiuCurent = stocareMateriiProgramStudiu.GetDetaliiMateriiProgramStudiu(programStudiuCurent.IdProgramStudiu);
                materiiBD = stocareMateriiProgramStudiu.GetDetaliiMateriiProgramStudiuDiferite(programStudiuCurent);
            }
        }

        private void FormAdaugareFacultate_Load(object sender, EventArgs e)
        {
            labelFacultateProgram.Text = $"{facultateCurenta.Denumire}\n{programStudiuCurent.Ciclu} {programStudiuCurent.Specializare}";
            if (materiiProgramStudiuCurent != null)
            {
                IncarcareDataGridView.AfisareMateriiProgramStudiu(dataGridViewMateriiCurente, materiiProgramStudiuCurent, 200);
                dataGridViewMateriiCurente.CurrentCell = null;
            }
            if (materiiBD != null)
            {
                IncarcareDataGridView.AfisareMateriiDataSet(dataGridViewMaterii, materiiBD, WIDTHNUME);
                dataGridViewMaterii.CurrentCell = null;
            }
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
            List<ProgramStudiuMaterie> materii = GetMateriiDataGrid(dataGridViewMaterii);
            if (materii.Count == 0) return;
            foreach (var item in materii)
            {
                var result = stocareMateriiProgramStudiu.AddProgramMaterie(item);
                if (result == false) MessageBox.Show("A aparut o problema la adaugarea materiei");
                itemAdaugat = true;
            }
            materiiBD = stocareMateriiProgramStudiu.GetDetaliiMateriiProgramStudiuDiferite(programStudiuCurent);
            dataGridViewMaterii.DataSource = null;
            IncarcareDataGridView.AfisareMateriiDataSet(dataGridViewMaterii, materiiBD,WIDTHNUME);
            materiiProgramStudiuCurent = stocareMateriiProgramStudiu.GetDetaliiMateriiProgramStudiu(programStudiuCurent.IdProgramStudiu);
            IncarcareDataGridView.AfisareMateriiProgramStudiu(dataGridViewMateriiCurente, materiiProgramStudiuCurent, WIDTHNUME);

            dataGridViewMateriiCurente.CurrentCell = null;
            dataGridViewMaterii.CurrentCell = null;

        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            List<ProgramStudiuMaterie> materii = GetMateriiDataGrid(dataGridViewMateriiCurente);
            if (materii.Count == 0) return;
            foreach (var item in materii)
            {
                Console.WriteLine(item.IdProgramStudiu + " " + item.IdMaterie);
                var result = stocareMateriiProgramStudiu.DeleteProgramMaterie(item);
                if (result == false) MessageBox.Show("A aparut o problema la eliminarea materiei");
                itemAdaugat = true; // itemEliminat
            }
            materiiBD = stocareMateriiProgramStudiu.GetDetaliiMateriiProgramStudiuDiferite(programStudiuCurent);
            dataGridViewMaterii.DataSource = null;
            //IncarcareDataGridView.AfisareMateriiDataSet(dataGridViewMaterii, materiiBD);
            IncarcareDataGridView.AfisareMateriiProgramStudiu(dataGridViewMaterii, materiiBD, WIDTHNUME);
            materiiProgramStudiuCurent = stocareMateriiProgramStudiu.GetDetaliiMateriiProgramStudiu(programStudiuCurent.IdProgramStudiu);
            IncarcareDataGridView.AfisareMateriiProgramStudiu(dataGridViewMateriiCurente, materiiProgramStudiuCurent, WIDTHNUME);
            dataGridViewMateriiCurente.CurrentCell = null;
            dataGridViewMaterii.CurrentCell = null;
        }

        #region ComboBox

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

        #region Functii

        private void IncarcaMateriiProgramStudiu(int idProgramStudiu)
        {
            try
            {
                dataGridViewMateriiCurente.DataSource = null;
                IncarcareDataGridView.AfisareMateriiProgramStudiu(dataGridViewMateriiCurente, stocareMateriiProgramStudiu.GetDetaliiMateriiProgramStudiu(idProgramStudiu), WIDTHNUME);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        #region Select

        private List<ProgramStudiuMaterie> GetMateriiDataGrid(DataGridView dataGridView)
        {
            try
            {
                List<ProgramStudiuMaterie> listaMaterii = new List<ProgramStudiuMaterie>();
                var selectedCells = dataGridView.SelectedRows;
                if (selectedCells.Count == 0)
                {
                    MessageBox.Show("Selectati cel putin o materie din tabel");
                    return null;
                }
                foreach (DataGridViewRow item in selectedCells)
                {
                    int idMaterie = Convert.ToInt32(dataGridView[PRIMA_COLOANA, item.Index].Value);
                    listaMaterii.Add(new ProgramStudiuMaterie(programStudiuCurent.IdProgramStudiu,idMaterie));
                }

                return listaMaterii;
            }
            catch (Exception)
            {
                throw;
            }
        }



        #endregion

        #endregion

        private void dataGridViewMateriiCurente_DataSourceChanged(object sender, EventArgs e)
        {
            labelNrMateriiCurente.Text = $"Nr.Materii Curente:{dataGridViewMateriiCurente.RowCount}";
            dataGridViewMateriiCurente.CurrentCell = null;
            dataGridViewMateriiCurente.Font = new Font("SEGOE UI", 13);

        }

        private void dataGridViewMaterii_DataSourceChanged(object sender, EventArgs e)
        {
            labelNrMateriiTotal.Text = $"Disponibile:{dataGridViewMaterii.RowCount}";
            dataGridViewMaterii.CurrentCell = null;
            dataGridViewMaterii.Font = new Font("SEGOE UI", 12);
        }
    }
}
