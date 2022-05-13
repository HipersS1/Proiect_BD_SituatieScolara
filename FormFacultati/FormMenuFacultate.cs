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
            IncarcaFacultati();
        }

        private void btnModifyFaculty_Click(object sender, EventArgs e)
        {
            using (FormModificareFacultate form = new FormModificareFacultate())
            {
                form.ShowDialog();
            }
        }

        

        private void FormMenuFacultate_Load(object sender, EventArgs e)
        {
            IncarcaFacultati();
        }

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
