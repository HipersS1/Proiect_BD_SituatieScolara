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
        private readonly IStocareNote stocareNote = (IStocareNote)new StocareFactory().GetTipStocare(typeof(Note));
        private readonly IStocareMaterii stocareMaterii = (IStocareMaterii)new StocareFactory().GetTipStocare(typeof(Materie));
        private readonly IStocareProgramStudiuMaterie stocareMateriiProgramStudiu = (IStocareProgramStudiuMaterie)new StocareFactory().GetTipStocare(typeof(ProgramStudiuMaterie));

        private Student studentToBeModified;
        private readonly Facultate facultateStudent;
        private readonly ProgramStudiu programStudiu;

        private bool itemModificat = false;

        public FormModificareStudent(Student student, Facultate facultate, ProgramStudiu program)
        {
            InitializeComponent();
            if (stocareStudenti == null || stocareFacultati == null || stocareProgrameStudii == null || stocareNote == null)
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

            if (studentToBeModified.An + 1 <= programStudiu.Durata)
            {
                IncarcareComboBox.IncarcaValoriNumerice(comboBoxAn, studentToBeModified.An, studentToBeModified.An+1);
            }
            else
                IncarcareComboBox.IncarcaValoriNumerice(comboBoxAn, studentToBeModified.An, studentToBeModified.An);
            comboBoxAn.SelectedIndex = 0;

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
                studentToBeModified = student;

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
                    comboBoxAn.Items.Clear();
                    IncarcareComboBox.IncarcaValoriNumerice(comboBoxAn, studentToBeModified.An, studentToBeModified.An + 1);
                    comboBoxAn.SelectedIndex = 0;

                    List<ProgramStudiuMaterie> listaMateriiProgramStudiu = stocareMateriiProgramStudiu.GetMateriiProgramStudiu(student.IdProgramStudiu);
                    List<Materie> listaMaterii = stocareMaterii.GetMaterii();
                    var materiiActualeStudent = stocareNote.GetNoteStudentList(student.IdStudent)
                                                .Select(n => n.IdMaterie).ToList();

                    var listaMateriiSpecificAnStudent = listaMaterii.Where(m => m.An <= student.An)
                                                                    .Select(m => m.IdMaterie)
                                                                    .ToList();

                    for (int i = 0; i < listaMateriiProgramStudiu.Count; i++)
                    {
                        if (listaMateriiSpecificAnStudent.Contains(listaMateriiProgramStudiu[i].IdMaterie) 
                            && !materiiActualeStudent.Contains(listaMateriiProgramStudiu[i].IdMaterie))
                        {
                            var materieAdaugata = stocareNote.AddNote(new Note(student.IdStudent, listaMateriiProgramStudiu[i].IdMaterie));

                            if (materieAdaugata == false)
                            {
                                MessageBox.Show("A aparut o problema cu adaugarea materie la student");
                                return;
                            }
                        }
                    }
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

        /// <summary>
        /// Validararea inputului
        /// </summary>
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

                var anStudent = Convert.ToInt32(comboBoxAn.SelectedItem.ToString());

                if (anStudent != studentToBeModified.An && ValideazaNoteStudent() == false)
                {
                    mesajEroare.Append($"Toate materiile necesita absolvite pentru a modifica anul\n");
                    comboBoxAn.SelectedIndex = 0;
                }

                if (!string.IsNullOrEmpty(mesajEroare.ToString()))
                {
                    MessageBox.Show($"{mesajEroare}");
                    return null;
                }

                return new Student(numeValid.Text, prenumeValid.Text, emailValid.Text, telefonValid.Text, anStudent, studentToBeModified.IdProgramStudiu, studentToBeModified.IdStudent);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o problema la validarea informatiilor despre student");
            }

            return null;
        }

        /// <summary>
        /// Verific daca toate notele studentului sunt >= 5
        /// </summary>
        private bool ValideazaNoteStudent()
        {
            var noteStudent = stocareNote.GetNoteStudentList(studentToBeModified.IdStudent);
            var noteTrecute = noteStudent.Where(n => n.NotaFinala >= 5).ToList();

            return noteTrecute.Count == noteStudent.Count ? true : false;
        }

        #endregion

    }
}
