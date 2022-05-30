using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Note
    {
        public decimal NotaLaborator { get; set; } = 0;
        public decimal NotaCurs { get; set; } = 0;
        public int NotaFinala { get; set; } = 0;

        // FK
        public int IdStudent { get; set; }
        public int IdMaterie { get; set; }

        public Note(int idStudent = 0, int idMaterie = 0)
        {
            IdStudent = idStudent;
            IdMaterie = idMaterie;
        }

        public Note(decimal notaLaborator, decimal notaCurs, int notaFinala, int idStudent = 0, int idMaterie = 0)
        {
            NotaLaborator = notaLaborator;
            NotaCurs = notaCurs;
            NotaFinala = notaFinala;
            IdStudent = idStudent;
            IdMaterie = idMaterie;
        }

        public Note(DataRow linieDB)
        {
            decimal nL, nC;

            if (linieDB["NotaLaborator"] == DBNull.Value)
            {
                NotaLaborator = -1;
            }
            else
                NotaLaborator = Convert.ToDecimal(linieDB["NotaLaborator"]);

            if (linieDB["NotaCurs"] == DBNull.Value)
            {
                NotaCurs = -1;
            }
            else
                NotaCurs = Convert.ToDecimal(linieDB["NotaCurs"]);

            if (linieDB["NotaFinala"] == DBNull.Value)
            {
                NotaFinala = -1;
            }
            else
                NotaFinala = Convert.ToInt32(linieDB["NotaFinala"]);

            IdStudent = Convert.ToInt32(linieDB["IdStudent"]);
            IdMaterie = Convert.ToInt32(linieDB["IdMaterie"]);
        }


        #region Equals
        public override bool Equals(object obj)
        {
            return obj is Note note &&
                   NotaLaborator == note.NotaLaborator &&
                   NotaCurs == note.NotaCurs &&
                   NotaFinala == note.NotaFinala &&
                   IdStudent == note.IdStudent &&
                   IdMaterie == note.IdMaterie;
        }

        public override int GetHashCode()
        {
            int hashCode = -44180601;
            hashCode = hashCode * -1521134295 + NotaLaborator.GetHashCode();
            hashCode = hashCode * -1521134295 + NotaCurs.GetHashCode();
            hashCode = hashCode * -1521134295 + NotaFinala.GetHashCode();
            hashCode = hashCode * -1521134295 + IdStudent.GetHashCode();
            hashCode = hashCode * -1521134295 + IdMaterie.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Note left, Note right)
        {
            return EqualityComparer<Note>.Default.Equals(left, right);
        }

        public static bool operator !=(Note left, Note right)
        {
            return !(left == right);
        }

        #endregion
    }
}
