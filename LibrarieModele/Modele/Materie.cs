using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Materie
    {
        private DataRow linieDB;

        public int IdMaterie { get; set; }
        public string Denumire { get; set; }
        public int An { get; set; }
        public int Semestru { get; set; }
        public int ProcentLaborator { get; set; }
        public int ProcentCurs { get; set; }

        public Materie(string denumire, int an, int semestru, int procentLaborator, int procentCurs, int idMaterie = 0)
        {
            IdMaterie = idMaterie;
            Denumire = denumire ?? throw new ArgumentNullException(nameof(denumire));
            An = an;
            Semestru = semestru;
            ProcentLaborator = procentLaborator;
            ProcentCurs = procentCurs;
        }

        public Materie(DataRow linieDB)
        {
            IdMaterie = Convert.ToInt32(linieDB["IdMaterie"]);
            Denumire = linieDB["Denumire"].ToString();
            An = Convert.ToInt32(linieDB["An"]);
            Semestru = Convert.ToInt32(linieDB["Semestru"]);
            ProcentLaborator = Convert.ToInt32(linieDB["ProcentLaborator"]);
            ProcentCurs = Convert.ToInt32(linieDB["ProcentCurs"]);
        }

        #region Equals
        public override bool Equals(object obj)
        {
            return obj is Materie materie &&
                   IdMaterie == materie.IdMaterie &&
                   Denumire == materie.Denumire &&
                   An == materie.An &&
                   Semestru == materie.Semestru &&
                   ProcentLaborator == materie.ProcentLaborator &&
                   ProcentCurs == materie.ProcentCurs;
        }

        public override int GetHashCode()
        {
            int hashCode = 755622846;
            hashCode = hashCode * -1521134295 + IdMaterie.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Denumire);
            hashCode = hashCode * -1521134295 + An.GetHashCode();
            hashCode = hashCode * -1521134295 + Semestru.GetHashCode();
            hashCode = hashCode * -1521134295 + ProcentLaborator.GetHashCode();
            hashCode = hashCode * -1521134295 + ProcentCurs.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Materie left, Materie right)
        {
            return EqualityComparer<Materie>.Default.Equals(left, right);
        }

        public static bool operator !=(Materie left, Materie right)
        {
            return !(left == right);
        }
        #endregion
    }
}
