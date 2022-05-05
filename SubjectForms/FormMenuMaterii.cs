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
    public partial class FormMenuMaterii : Form
    {
        public FormMenuMaterii()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (FormAdaugareStudent form = new FormAdaugareStudent())
            {
                form.ShowDialog();
            }
        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            using (FormModificareStudent form = new FormModificareStudent())
            {
                form.ShowDialog();
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            using (FormAdaugaNote form = new FormAdaugaNote())
            {
                form.ShowDialog();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInitializare form = new FormInitializare();
            form.ShowDialog();
        }

        private void FormMenuStudent_FormClosed(object sender, FormClosingEventArgs e)
        {

        }

        private void FormMenuStudent_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            using (FormAdaugareMaterie form = new FormAdaugareMaterie())
            {
                form.ShowDialog();
            }
        }
    }
}
