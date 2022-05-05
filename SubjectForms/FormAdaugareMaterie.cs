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
    public partial class FormAdaugareMaterie : Form
    {
        public FormAdaugareMaterie()
        {
            InitializeComponent();
        }

        private void btnMenuStudents_Click(object sender, EventArgs e)
        {
            using(FormMenuStudent form = new FormMenuStudent())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void btnMenuUniversity_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpCourse_ValueChanged(object sender, EventArgs e)
        {
            numericUpLaboratory.Value = 100 - numericUpCourse.Value ;
        }

        private void numericUpLaboratory_ValueChanged(object sender, EventArgs e)
        {
            numericUpCourse.Value = 100 - numericUpLaboratory.Value;
        }
    }
}
