using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace Proiect_BD_SituatieScolara
{
    public partial class FormInitializare : Form
    {
        public FormInitializare()
        {
            InitializeComponent();
        }

        private void btnMenuStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuStudent form = new FormMenuStudent();
            form.ShowDialog();
            this.Show();
        }

        private void btnMenuUniversity_Click(object sender, EventArgs e)
        {            
            this.Hide();
            FormMenuFacultate form = new FormMenuFacultate();
            form.ShowDialog();
            this.Show();
        }

        private void btnMenuMaterii_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuMaterii form = new FormMenuMaterii();
            form.ShowDialog();
            this.Show();
        }
    }
}
