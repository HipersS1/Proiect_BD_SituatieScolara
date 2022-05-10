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

        public FormMenuFacultate()
        {
            InitializeComponent();
            if(stocareFacultati == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

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
            AfisareFacultati();
        }

        private void btnModifyFaculty_Click(object sender, EventArgs e)
        {
            using (FormModificareFacultate form = new FormModificareFacultate())
            {
                form.ShowDialog();
            }
        }

        private void AfisareFacultati()
        {
            try
            {
                var facultati = stocareFacultati.GetFacultati();
                if (facultati != null && facultati.Any())
                {
                    dataGridView1.DataSource = facultati.Select(f => new { f.IdFacultate, f.Denumire, f.ProgramStudiu, f.Specializare, f.Durata }).ToList();

                    dataGridView1.Columns["IdFacultate"].Visible = false;
                    dataGridView1.Columns["Denumire"].HeaderText = "Denumire";
                    dataGridView1.Columns["ProgramStudiu"].HeaderText = "ProgramStudiu";
                    dataGridView1.Columns["Specializare"].HeaderText = "Specializare";
                    dataGridView1.Columns["Durata"].HeaderText = "Durata";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormMenuFacultate_Load(object sender, EventArgs e)
        {
            AfisareFacultati();
        }
    }
}
