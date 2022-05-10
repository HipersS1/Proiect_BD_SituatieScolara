using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace Proiect_BD_SituatieScolara
{
    public partial class FormAdaugareMaterie : Form
    {
        //IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));

        public FormAdaugareMaterie()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpCourse_ValueChanged(object sender, EventArgs e)
        {
            numericUpLaborator.Value = 100 - numericUpCurs.Value ;
        }

        private void numericUpLaboratory_ValueChanged(object sender, EventArgs e)
        {
            numericUpCurs.Value = 100 - numericUpLaborator.Value;
        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            
        }
    }
}
