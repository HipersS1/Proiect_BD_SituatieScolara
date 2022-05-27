using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class ProgramStudiu
    {
        public int IdProgramStudiu { get; set; }
        public string Ciclu { get; set; }
        public string Specializare { get; set; }
        public int Durata { get; set; }
        public int IdFacultate { get; set; }

        #region Constructors
        public ProgramStudiu()
        {

        }

        public ProgramStudiu(string ciclu, string specializare, int durata, int idFacultate = 0, int idProgramStudiu = 0)
        {
            this.IdProgramStudiu = idProgramStudiu;
            this.Ciclu = ciclu;
            this.Specializare = specializare;
            this.Durata = durata;
            this.IdFacultate = idFacultate;
        }

        public ProgramStudiu(DataRow linieDB)
        {
            this.IdProgramStudiu = Convert.ToInt32(linieDB["IdProgramStudiu"]);
            this.Ciclu = linieDB["Ciclu"].ToString();
            this.Specializare = linieDB["Specializare"].ToString();
            this.Durata = Convert.ToInt32(linieDB["Durata"]);
            this.IdFacultate = Convert.ToInt32(linieDB["IdFacultate"]);
        }
        #endregion

    }
}
