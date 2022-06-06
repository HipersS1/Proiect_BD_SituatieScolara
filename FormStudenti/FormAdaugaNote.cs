using LibrarieModele;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect_BD_SituatieScolara
{
    public partial class FormAdaugaNote : Form
    {
        private readonly IStocareMaterii stocareMaterii = (IStocareMaterii)new StocareFactory().GetTipStocare(typeof(Materie));
        private readonly IStocareNote stocareNote = (IStocareNote)new StocareFactory().GetTipStocare(typeof(Note));

        private readonly Student studentCurrent;
        private readonly Facultate facultateCurenta;
        private readonly ProgramStudiu programStudiuCurent;
        private List<int> idMateriiActualizate = new List<int>();

        //
        private const int WIDTHNUME = 230;

        public FormAdaugaNote(Student student, Facultate facultate, ProgramStudiu programStudiu)
        {
            InitializeComponent();
            studentCurrent = student;
            facultateCurenta = facultate;
            programStudiuCurent = programStudiu;

            if(stocareMaterii == null || stocareNote == null)
            {
                MessageBox.Show("Eroare la initializare");
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
            bool succes = false;
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
                        succes = true;
                    }
                }
            }
            if (succes == true)
                MessageBox.Show("Actualizarea a avut succes");

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
                IncarcareDataGridView.AfisareDataSetMateriiNote(dataGridView1, materii, WIDTHNUME);
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

            var cellNotaLab = dataGridView1.Rows[rowIndex].Cells["NOTALABORATOR"].Value;
            var cellNotaCurs = dataGridView1.Rows[rowIndex].Cells["NOTACURS"].Value;

            int procentLab = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["PROCENTLABORATOR"].Value);
            int procentCurs = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["PROCENTCURS"].Value);

            
            var idMaterie = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["IDMATERIE"].Value);


            if (columnIndex == dataGridView1.Rows[0].Cells["NOTALABORATOR"].ColumnIndex && cellNotaLab != DBNull.Value)
            {
                decimal notaLab = Convert.ToDecimal(cellNotaLab);
                if (!NotaValida(notaLab))
                {
                    dataGridView1.Rows[rowIndex].Cells["NOTALABORATOR"].Value = DBNull.Value;
                    MessageBox.Show("Nota de la laborator trebuie sa fie in intervalul [1.00, 10.00]");
                    return;
                }
                if (cellNotaCurs != DBNull.Value)
                {
                    decimal notaCurs = Convert.ToDecimal(cellNotaCurs);

                    dataGridView1.Rows[rowIndex].Cells["NOTAFINALA"].Value = CalculeazaNotaFinala(notaLab, notaCurs, procentLab, procentCurs);

                    if (!idMateriiActualizate.Contains(idMaterie))
                    {
                        idMateriiActualizate.Add(idMaterie);
                    }
                }
            }

            if (columnIndex == dataGridView1.Rows[0].Cells["NOTACURS"].ColumnIndex && cellNotaCurs != DBNull.Value)
            {
                decimal notaCurs = Convert.ToDecimal(cellNotaCurs);
                if (!NotaValida(notaCurs))
                {
                    dataGridView1.Rows[rowIndex].Cells["NOTACURS"].Value = DBNull.Value;
                    MessageBox.Show("Nota de la curs trebuie sa fie in intervalul [1.00, 10.00]");
                    return;
                }

                if (cellNotaLab != DBNull.Value)
                {
                    decimal notaLab = Convert.ToDecimal(cellNotaLab);
                    

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

        private void dataGridView1_DataSourceChanged_1(object sender, EventArgs e)
        {
            labelNumarElemente.Text = $"Nr.Elemente: {dataGridView1.RowCount}";
            dataGridView1.Font = new Font("SEGOE UI", 14);
            dataGridView1.CurrentCell = null;
        }

        private bool NotaValida(decimal numar)
        {
            if (numar >= 1.00m && numar <= 10.00m)
            {
                return true;
            }
            return false;
        }
    }
}
