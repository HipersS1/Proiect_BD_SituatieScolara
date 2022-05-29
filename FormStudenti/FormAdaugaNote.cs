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
    public partial class FormAdaugaNote : Form
    {
        private readonly IStocareStudenti stocareStudenti = (IStocareStudenti)new StocareFactory().GetTipStocare(typeof(Student));
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private readonly IStocareMaterii stocareMaterii = (IStocareMaterii)new StocareFactory().GetTipStocare(typeof(Materie));
        private readonly IStocareNote stocareNote = (IStocareNote)new StocareFactory().GetTipStocare(typeof(Note));

        private readonly Student studentCurrent;
        private readonly Facultate facultateCurenta;
        private readonly ProgramStudiu programStudiuCurent;
        private List<int> idMateriiActualizate = new List<int>();

        public FormAdaugaNote(Student student, Facultate facultate, ProgramStudiu programStudiu)
        {
            InitializeComponent();
            studentCurrent = student;
            facultateCurenta = facultate;
            programStudiuCurent = programStudiu;

            if(stocareMaterii == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
            else
            {
                
            }

        }

        private void FormAdaugaNote_Load(object sender, EventArgs e)
        {
            IncarcaInformatiiMateriiNote(stocareNote.GetNoteStudent(studentCurrent.IdStudent));

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Facultatea: {facultateCurenta.Denumire}");
            sb.AppendLine($"Program Studiu: {programStudiuCurent.Ciclu} {programStudiuCurent.Specializare}");
            sb.AppendLine($"Student: {studentCurrent.Nume} {studentCurrent.Prenume} An: {studentCurrent.An}");


            richTextBoxFacultate.Text = sb.ToString();
        }

        #region Form events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int idMaterie = Convert.ToInt32(row.Cells["IDMATERIE"].Value);
                if (idMateriiActualizate.Contains(idMaterie))
                {
                    decimal notaLab = Convert.ToDecimal(row.Cells["NOTALABORATOR"].Value);
                    decimal notaCurs = Convert.ToDecimal(row.Cells["NOTACURS"].Value);
                    int notaFinala = Convert.ToInt32(row.Cells["NOTAFINALA"].Value);

                    Note note = new Note(notaLab, notaCurs, notaFinala, studentCurrent.IdStudent, idMaterie);

                    var resultMaterieActualizata = stocareNote.UpdateNote(note);
                    if (resultMaterieActualizata == false)
                    {
                        MessageBox.Show("Problema la actualizarea materiilor");
                    }
                    else
                    {
                        idMateriiActualizate.Remove(idMaterie);
                        MessageBox.Show("Actualizarea a avut succes");
                    }
                }
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            dataGrid.CurrentCell = null;
        }

        #endregion


        #region Functii
        private void IncarcaInformatiiMateriiNote(DataSet materii)
        {
            try
            {
                IncarcareDataGridView.AfisareDataSetMateriiNote(dataGridView1, materii);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        #endregion

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;

            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            int procentLab = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["PROCENTLABORATOR"].Value);
            int procentCurs = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["PROCENTCURS"].Value);

            var cellNotaLab = dataGridView1.Rows[rowIndex].Cells["NOTALABORATOR"];
            var cellNotaCurs = dataGridView1.Rows[rowIndex].Cells["NOTACURS"];
            var idMaterie = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["IDMATERIE"].Value);

            if (columnIndex == dataGridView1.Rows[0].Cells["NOTALABORATOR"].ColumnIndex)
            {

                if (cellNotaCurs.Value != DBNull.Value)
                {
                    decimal notaLab = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells["NOTALABORATOR"].Value);
                    decimal notaCurs = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells["NOTACURS"].Value);

                    dataGridView1.Rows[rowIndex].Cells["NOTAFINALA"].Value = CalculeazaNotaFinala(notaLab, notaCurs, procentLab, procentCurs);

                    if (!idMateriiActualizate.Contains(idMaterie))
                    {
                        idMateriiActualizate.Add(idMaterie);
                    }
                }
            }

            if (columnIndex == dataGridView1.Rows[0].Cells["NOTACURS"].ColumnIndex)
            {
                if (cellNotaLab.Value != DBNull.Value)
                {
                    decimal notaLab = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells["NOTALABORATOR"].Value);
                    decimal notaCurs = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells["NOTACURS"].Value);

                    dataGridView1.Rows[rowIndex].Cells["NOTAFINALA"].Value = CalculeazaNotaFinala(notaLab, notaCurs, procentLab, procentCurs);
                    if (!idMateriiActualizate.Contains(idMaterie))
                    {
                        idMateriiActualizate.Add(idMaterie);
                    }
                }                
            }
        }

        private int CalculeazaNotaFinala(decimal notaLab, decimal notaCurs, int procentLab, int procentCurs)
        {
            var f = (((decimal)procentLab / 100) * notaLab) + ((decimal)procentCurs / 100) * notaCurs;
            return (int)f;
        }


    }
}
