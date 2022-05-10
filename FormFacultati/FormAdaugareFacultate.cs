using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;



namespace Proiect_BD_SituatieScolara
{
    public partial class FormAdaugareFacultate : Form
    {
        IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));

        public FormAdaugareFacultate()
        {
            InitializeComponent();
            IncarcaSpecializari(comboBoxProgramStudiu);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            try
            {
                Facultate facultate = ValideazaInformatii();
                if (facultate == null)
                {
                    return;
                }

                var rezultat = stocareFacultati.AddFacultate(facultate);

                if(rezultat == true)
                {
                    MessageBox.Show("Facultatea a fost adaugata");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Facultatea nu a fost adaugata cu succes");
            }
        }
        #region Validari

        private Facultate ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var denumireValida = ValidareString.ValideazaDenumire(textBoxDenumire.Text);
                if (string.IsNullOrEmpty(denumireValida.Text))
                {
                    mesajEroare.Append($"Denumire:{textBoxDenumire.Text} : {denumireValida.Mesaj}\n");
                    // fa culoare rosie la label
                }
                
                if(comboBoxProgramStudiu.SelectedItem == null)
                {
                    mesajEroare.Append($"Program Studiu: Selectati o valoare\n");
                }

                var specializareValida = ValidareString.ValideazaDenumire(textBoxSpecializare.Text);
                if (string.IsNullOrEmpty(specializareValida.Text))
                {
                    mesajEroare.Append($"Specializare:{textBoxSpecializare.Text} : {specializareValida.Mesaj}");
                    // fa culoare rosie la label
                }

                if(!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                return new Facultate(denumireValida.Text, comboBoxProgramStudiu.SelectedItem.ToString(), specializareValida.Text, Convert.ToInt32(textBoxDurata.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema");
            }

            return null;
        }


        #endregion

        #region Incarcare informatii

        private void IncarcaSpecializari(ComboBox comboBox)
        {
            
            foreach(var specializare in ProgramStudiu.GetProgrameStudii())
            {
                comboBox.Items.Add(specializare);
            }

        }

        #endregion
    }
}
