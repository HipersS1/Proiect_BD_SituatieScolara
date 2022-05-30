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
        FormWindowState currentWindowState;
        bool isFulscreen;
        public FormInitializare()
        {
            InitializeComponent();
            currentWindowState = this.WindowState;
            isFulscreen = false;
        }

        private void btnMenuStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuStudent form = new FormMenuStudent(this.WindowState);
            form.ShowDialog();
            this.Show();
            // window state
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
        private void Form1_Resize(object sender, EventArgs e)
        {

            // When window state changes
            if (WindowState != currentWindowState)
            {
                currentWindowState = WindowState;


                if (WindowState == FormWindowState.Maximized)
                {
                    isFulscreen = true;
                }
                if (WindowState == FormWindowState.Normal)
                {
                    isFulscreen = false;
                }
            }

        }
    }
}
