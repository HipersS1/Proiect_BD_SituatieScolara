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

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInitializare form = new FormInitializare();
            form.ShowDialog();
        }


        private void btnAdaguaMaterie_Click(object sender, EventArgs e)
        {
            using (FormAdaugareMaterie form = new FormAdaugareMaterie())
            {
                form.ShowDialog();
            }
        }

        private void btnModificaMaterie_Click(object sender, EventArgs e)
        {
            using (FormModificareMaterie form = new FormModificareMaterie())
            {
                form.ShowDialog();
            }
        }
    }
}
