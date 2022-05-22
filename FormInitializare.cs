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
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)

        public FormInitializare()
        {
            InitializeComponent();
        }

        private void btnMenuStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuStudent form = new FormMenuStudent();
            form.ShowDialog();
            this.Close();
        }

        private void btnMenuUniversity_Click(object sender, EventArgs e)
        {            
            this.Hide();
            FormMenuFacultate form = new FormMenuFacultate();
            form.ShowDialog();
            this.Close();
        }

        private void btnMenuMa_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuMaterii form = new FormMenuMaterii();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
