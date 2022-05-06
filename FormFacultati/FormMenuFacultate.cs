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
    public partial class FormMenuFacultate : Form
    {
        public FormMenuFacultate()
        {
            InitializeComponent();
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
        }

        private void btnModifyFaculty_Click(object sender, EventArgs e)
        {
            using (FormModificareFacultate form = new FormModificareFacultate())
            {
                form.ShowDialog();
            }
        }
    }
}
