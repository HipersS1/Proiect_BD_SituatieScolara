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
                facultateCurenta = stocareFacultati.GetFacultate(student.IdProgramStudiu);
            }

        }

        private void FormAdaugaNote_Load(object sender, EventArgs e)
        {
            //IncarcaInformatiiMateriiNote(stocareNote.GetNoteStudent(studentCurrent.IdStudent));

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

        #endregion


        #region Functii
        private void IncarcaInformatiiMateriiNote(List<Materie> materii)
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

    }
}
