using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int An { get; set; }

        // FK
        public int IdProgramStudiu { get; set; }

        #region  Constructors
        public Student()
        {
        }
        public Student(string nume, string prenume, string email, string telefon, int an, int idFacultate, int idStudent = 0)
        {
            IdStudent = idStudent;
            Nume = nume ?? throw new ArgumentNullException(nameof(nume));
            Prenume = prenume ?? throw new ArgumentNullException(nameof(prenume));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Telefon = telefon ?? throw new ArgumentNullException(nameof(telefon));
            An = an;
            IdProgramStudiu = idFacultate;
        }

        public Student(DataRow linieDB)
        {
            IdStudent = Convert.ToInt32(linieDB["IdStudent"]);
            Nume = linieDB["Nume"].ToString();
            Prenume = linieDB["Prenume"].ToString();
            Email = linieDB["Email"].ToString();
            Telefon = linieDB["Telefon"].ToString();
            An = Convert.ToInt32(linieDB["An"]);
            IdProgramStudiu = Convert.ToInt32(linieDB["IdProgramStudiu"]);
        }
        #endregion

        #region Equals
        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   IdStudent == student.IdStudent &&
                   Nume == student.Nume &&
                   Prenume == student.Prenume &&
                   Email == student.Email &&
                   Telefon == student.Telefon &&
                   An == student.An &&
                   IdProgramStudiu == student.IdProgramStudiu;
        }

        public override int GetHashCode()
        {
            int hashCode = -80433014;
            hashCode = hashCode * -1521134295 + IdStudent.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nume);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenume);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefon);
            hashCode = hashCode * -1521134295 + An.GetHashCode();
            hashCode = hashCode * -1521134295 + IdProgramStudiu.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Student left, Student right)
        {
            return EqualityComparer<Student>.Default.Equals(left, right);
        }

        public static bool operator !=(Student left, Student right)
        {
            return !(left == right);
        }
        #endregion
    }
}
