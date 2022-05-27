using LibrarieModele;
using NivelAccesDate;
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
    public partial class FormModificareStudent : Form
    {
        private readonly IStocareStudenti stocareStudenti = (IStocareStudenti)new StocareFactory().GetTipStocare(typeof(Student));
        private readonly IStocareFacultati stocareFacultati = (IStocareFacultati)new StocareFactory().GetTipStocare(typeof(Facultate));
        private readonly IStocareProgrameStudii stocareProgrameStudii = (IStocareProgrameStudii)new StocareFactory().GetTipStocare(typeof(ProgramStudiu));

        private Student studentToBeModified;
        private readonly Facultate facultateStudent;
        private readonly ProgramStudiu programStudiu;

        private bool itemModificat = false;

        public FormModificareStudent(Student student, Facultate facultate, ProgramStudiu program)
        {
            InitializeComponent();
            if (stocareStudenti == null || stocareFacultati == null || stocareProgrameStudii == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
            studentToBeModified = student;
            programStudiu = program;
            facultateStudent = facultate;
        }

        private void FormModificareStudent_Load(object sender, EventArgs e)
        {
            textBoxPrenume.Text = studentToBeModified.Prenume;
            textBoxNume.Text = studentToBeModified.Nume;
            textBoxEmail.Text = studentToBeModified.Email;
            textBoxTelefon.Text = studentToBeModified.Telefon;

            IncarcareComboBox.IncarcaValoriNumerice(comboBoxAn, programStudiu.Durata);
            comboBoxAn.SelectedIndex = studentToBeModified.An - 1;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Denumirea Facultatii");
            sb.AppendLine($"{facultateStudent.Denumire}");
            sb.Append($"Program de studiu: {programStudiu.Ciclu} {programStudiu.Specializare}");
            richTextBoxFacultate.Text = sb.ToString();
        }

        #region Form Events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (itemModificat == true)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            try
            {
                ClearResetFormComponents.ResetColors(panelInputs.Controls.OfType<Label>());
                Student student = ValideazaInformatii();
                if (student == null)
                    return;


                if (stocareStudenti.ValideazaExistenta(student))
                {
                    MessageBox.Show("Studentul exista deja");
                    return;
                }

                var rezultat = stocareStudenti.UpdateStudent(student);

                if (rezultat == true)
                {
                    MessageBox.Show("Studentul a fost modificat");
                    itemModificat = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Studentul nu a fost modificat cu succes");
            }

        }

        #endregion



        #region PlaceHolders


        private void textBoxPlaceholder_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox) sender;

            if(textBox == textBoxPrenume && textBox.Text == studentToBeModified.Prenume)
            {
                textBox.Text = "";
            }

            if (textBox == textBoxNume && textBox.Text == studentToBeModified.Nume)
            {
                textBox.Text = "";
            }

            if (textBox == textBoxEmail && textBox.Text == studentToBeModified.Email)
            {
                textBox.Text = "";
            }
            if (textBox == textBoxTelefon && textBox.Text == studentToBeModified.Telefon)
            {
                textBox.Text = "";
            }

        }
        private void textBoxPlaceholder_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if(String.IsNullOrEmpty(textBox.Text))
            {
                if (textBox == textBoxPrenume)
                {
                    textBox.Text = studentToBeModified.Prenume;
                }
                if (textBox == textBoxNume)
                {
                    textBox.Text = studentToBeModified.Nume;
                }
                if (textBox == textBoxEmail)
                {
                    textBox.Text = studentToBeModified.Email;
                }
                if (textBox == textBoxTelefon)
                {
                    textBox.Text = studentToBeModified.Telefon;
                }
            }
        }


        #endregion


        #region Functii

        private Student ValideazaInformatii()
        {
            try
            {
                StringBuilder mesajEroare = new StringBuilder();

                var numeValid = ValidareString.ValideazaDenumire(textBoxNume.Text);
                if (string.IsNullOrEmpty(numeValid.Text))
                {
                    mesajEroare.Append($"{labelNume.Text} : {numeValid.Mesaj}\n");
                    labelNume.ForeColor = Color.Red;
                }

                var prenumeValid = ValidareString.ValideazaDenumire(textBoxPrenume.Text);
                if (string.IsNullOrEmpty(prenumeValid.Text))
                {
                    mesajEroare.Append($"{labelPrenume.Text} : {prenumeValid.Mesaj}\n");
                    labelPrenume.ForeColor = Color.Red;
                }

                var emailValid = ValidareString.ValideazaEmail(textBoxEmail.Text);
                if (string.IsNullOrEmpty(emailValid.Text))
                {
                    mesajEroare.Append($"{labelEmail.Text} : {emailValid.Mesaj}\n");
                    labelEmail.ForeColor = Color.Red;
                }

                var telefonValid = ValidareString.ValideazaNumarTelefon(textBoxTelefon.Text);
                if (string.IsNullOrEmpty(telefonValid.Text))
                {
                    mesajEroare.Append($"{labelTelefon.Text} : {telefonValid.Mesaj}\n");
                    labelTelefon.ForeColor = Color.Red;
                }

                if (comboBoxAn.SelectedIndex == -1)
                {
                    mesajEroare.Append($"{labelAn.Text} Selecteaza o optiune\n");
                    labelAn.ForeColor = Color.Red;
                }

                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                var anStudent = Convert.ToInt32(comboBoxAn.SelectedItem.ToString());

                return new Student(numeValid.Text, prenumeValid.Text, emailValid.Text, telefonValid.Text, anStudent, studentToBeModified.IdProgramStudiu, studentToBeModified.IdStudent);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la validarea informatiilor despre student");
            }

            return null;
        }
        #endregion

    }
}
