using System;
using System.Data;

namespace LibrarieModele
{
    public class Facultate
    {
        public int IdFacultate { get; set; }
        public string Denumire { get; set; }
        

        #region Constructors
        public Facultate()
        {
        }

        public Facultate(string denumire, int idFacultate = 0)
        {
            this.IdFacultate = idFacultate;
            this.Denumire = denumire;
        }

        public Facultate (DataRow linieDB)
        {
            this.IdFacultate = Convert.ToInt32(linieDB["IdFacultate"]);
            this.Denumire = linieDB["Denumire"].ToString();
        }

        #endregion

    }
}
