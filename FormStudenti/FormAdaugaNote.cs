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


        public FormAdaugaNote(Student student)
        {
            InitializeComponent();
            studentCurrent = student;
            facultateCurenta = stocareFacultati.GetFacultate(student.IdFacultate);
            if(stocareMaterii == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
            else
            {
                IncarcaInformatiiMateriiNote(stocareNote.GetNoteStudent(student.IdStudent));
            }

        }

        private void FormAdaugaNote_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Student: {studentCurrent.Nume} {studentCurrent.Prenume} An: {studentCurrent.An}");
            sb.AppendLine($"Denumirea facultatii: {facultateCurenta.Denumire}");
            sb.AppendLine($"Program studiu: {facultateCurenta.ProgramStudiu}");
            sb.AppendLine($"Specializare: {facultateCurenta.Specializare}");

            richTextBoxFacultate.Text = sb.ToString();
        }

        #region Form events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Functii
        private void IncarcaInformatiiMateriiNote(DataSet dataSet)
        {
            try
            {
                IncarcareDataGridView.AfisareDataSetMateriiNote(dataGridView1, dataSet);
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
