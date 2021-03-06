using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarieModele
{
    /// <summary>
    /// Clasa incarca informatii in componente de tip DataGridView
    /// </summary>
    public static class IncarcareDataGridView
    {
        /// <summary>
        /// Incarca informatiile despre facultati in DataGridView
        /// </summary>
        public static void AfisareFacultati(DataGridView dataGridView, List<Facultate> facultati)
        {
            try
            {
                if (facultati != null && facultati.Any())
                {
                    dataGridView.DataSource = facultati.Select(f => new { f.IdFacultate, f.Denumire})
                                                       .OrderBy(d => d.Denumire)
                                                       .ToList();
                    
                    dataGridView.Columns["IdFacultate"].Visible = false;
                    dataGridView.Columns["Denumire"].HeaderText = "Denumire";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void AfisareProgrameStudii(DataGridView dataGridView, List<ProgramStudiu> programe, int idFacultate)
        {
            try
            {
                if (programe != null && programe.Any())
                {
                    dataGridView.DataSource = programe.Where(f => f.IdFacultate == idFacultate)
                                                      .Select(f => new { f.IdProgramStudiu, f.Ciclu, f.Specializare, f.Durata, f.IdFacultate})
                                                      .OrderBy(d => d.Specializare)
                                                      .ToList();

                    dataGridView.Columns["IdFacultate"].Visible = false;
                    dataGridView.Columns["IdProgramStudiu"].Visible = false;

                    dataGridView.Columns["Ciclu"].HeaderText = "Ciclu de studiu";
                    dataGridView.Columns["Specializare"].HeaderText = "Specializare";
                    dataGridView.Columns["Durata"].HeaderText = "Durata";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void AfisareMateriiProgramStudiu(DataGridView dataGridView, DataSet materiiProgramStudiu, int widthDenumire)
        {
            try
            {
                if (materiiProgramStudiu != null)
                {
                    dataGridView.DataSource = materiiProgramStudiu.Tables[0];

                    dataGridView.Columns["IdMaterie"].Visible = false;
                    dataGridView.Columns["DENUMIRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView.Columns["DENUMIRE"].HeaderText = "Denumire";
                    dataGridView.Columns["DENUMIRE"].Width = widthDenumire;
                    dataGridView.Columns["An"].HeaderText = "An";
                    dataGridView.Columns["Semestru"].HeaderText = "Semestru";
                    dataGridView.Columns["ProcentLaborator"].HeaderText = "Procent laborator";
                    dataGridView.Columns["ProcentCurs"].HeaderText = "Procent curs";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void AfisareStudentiDataSet(DataGridView dataGridView, DataSet studenti)
        {
            try
            {
                if (studenti != null)
                {
                    dataGridView.DataSource = studenti.Tables[0];

                    dataGridView.Columns["IDSTUDENT"].Visible = false;
                    dataGridView.Columns["IdFacultate"].Visible = false;
                    dataGridView.Columns["IdProgramStudiu"].Visible = false;

                    dataGridView.Columns["Student"].HeaderText = "Student";
                    dataGridView.Columns["EMAIL"].HeaderText = "Email";

                    dataGridView.Columns["TELEFON"].HeaderText = "Telefon";

                    dataGridView.Columns["FACULTATE"].HeaderText = "Facultate";
                    dataGridView.Columns["Program"].HeaderText = "Programul de studiu";

                    dataGridView.Columns["AN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView.Columns["AN"].HeaderText = "An";
                    dataGridView.Columns["AN"].Width = 30;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void AfisareMaterii(DataGridView dataGridView, List<Materie> materii, int widthNume)
        {
            try
            {
                if (materii != null && materii.Any())
                {
                    dataGridView.DataSource = materii.Select(f => new { f.IdMaterie, f.Denumire, f.An, f.Semestru, f.ProcentLaborator, f.ProcentCurs})
                                                     .Distinct()
                                                     .OrderBy(s => s.Denumire)
                                                     .ToList();

                    dataGridView.Columns["IdMaterie"].Visible = false;
                    dataGridView.Columns["DENUMIRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView.Columns["DENUMIRE"].HeaderText = "Denumire";
                    dataGridView.Columns["DENUMIRE"].Width = widthNume;
                    dataGridView.Columns["An"].HeaderText = "An";
                    dataGridView.Columns["Semestru"].HeaderText = "Semestru";
                    dataGridView.Columns["ProcentLaborator"].HeaderText = "Procent laborator";
                    dataGridView.Columns["ProcentCurs"].HeaderText = "Procent curs";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void AfisareMateriiDataSet(DataGridView dataGridView, DataSet materii, int widthDenumire)
        {
            try
            {
                if (materii != null)
                {
                    dataGridView.DataSource = materii.Tables[0];

                    dataGridView.Columns["IDMATERIE"].Visible = false;
                    dataGridView.Columns["DENUMIRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView.Columns["DENUMIRE"].HeaderText = "Denumire";
                    dataGridView.Columns["DENUMIRE"].Width = widthDenumire;
                    dataGridView.Columns["AN"].HeaderText = "An";
                    dataGridView.Columns["SEMESTRU"].HeaderText = "Semestru";
                    dataGridView.Columns["PROCENTLABORATOR"].HeaderText = "Procent Laborator";
                    dataGridView.Columns["PROCENTCURS"].HeaderText = "Procent curs";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void AfisareDataSetMateriiNote(DataGridView dataGridView, DataSet materiiNote, int widthDenumire)
        {
            try
            {
                if (materiiNote != null)
                {
                    dataGridView.DataSource = materiiNote.Tables[0];
                    //Materie
                    dataGridView.Columns["IDMATERIE"].Visible = false;
                    dataGridView.Columns["DENUMIRE"].ReadOnly = true;
                    dataGridView.Columns["DENUMIRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView.Columns["DENUMIRE"].HeaderText = "Denumire";
                    dataGridView.Columns["DENUMIRE"].Width = widthDenumire;
                   

                    dataGridView.Columns["AN"].ReadOnly = true;
                    dataGridView.Columns["AN"].HeaderText = "An";

                    dataGridView.Columns["SEMESTRU"].ReadOnly = true;
                    dataGridView.Columns["SEMESTRU"].HeaderText = "Semestru";

                    dataGridView.Columns["PROCENTLABORATOR"].ReadOnly = true;
                    dataGridView.Columns["PROCENTLABORATOR"].HeaderText = "Procent Laborator";

                    dataGridView.Columns["PROCENTCURS"].ReadOnly = true;
                    dataGridView.Columns["PROCENTCURS"].HeaderText = "Procent curs";


                    // Note
                    dataGridView.Columns["NOTALABORATOR"].HeaderText = "Nota laborator";
                    dataGridView.Columns["NOTACURS"].HeaderText = "Nota curs";
                    dataGridView.Columns["NOTAFINALA"].ReadOnly = true;
                    dataGridView.Columns["NOTAFINALA"].HeaderText = "Nota finala";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
