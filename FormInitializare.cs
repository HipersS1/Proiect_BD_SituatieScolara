using System;
using System.Windows.Forms;

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
            FormMenuStudent form = new FormMenuStudent(this.WindowState);
            form.ShowDialog();
            this.Show();
            this.WindowState = form.WindowState;
            this.Location = form.Location;
        }

        private void btnMenuUniversity_Click(object sender, EventArgs e)
        {            
            this.Hide();
            FormMenuFacultate form = new FormMenuFacultate(this.WindowState);
            form.ShowDialog();
            this.Show();
            this.WindowState = form.WindowState;
            this.Location = form.Location;
        }

        private void btnMenuMaterii_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuMaterii form = new FormMenuMaterii(this.WindowState);
            form.ShowDialog();
            this.Show();
            this.WindowState = form.WindowState;
            this.Location = form.Location;
        }
    }
}
