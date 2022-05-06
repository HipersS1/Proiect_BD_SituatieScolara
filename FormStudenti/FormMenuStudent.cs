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
    public partial class FormMenuStudent : Form
    {
        public FormMenuStudent()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInitializare form = new FormInitializare();
            form.ShowDialog();
        }

        private void btnAdaugaStudent_Click(object sender, EventArgs e)
        {
            using (FormAdaugareStudent form = new FormAdaugareStudent())
            {
                form.ShowDialog();
            }
        }

        private void btnModificaStudent_Click(object sender, EventArgs e)
        {
            using (FormModificareStudent form = new FormModificareStudent())
            {
                form.ShowDialog();
            }
        }

        private void btnAdaugaNote_Click(object sender, EventArgs e)
        {
            using (FormAdaugaNote form = new FormAdaugaNote())
            {
                form.ShowDialog();
            }
        }
    }
}
