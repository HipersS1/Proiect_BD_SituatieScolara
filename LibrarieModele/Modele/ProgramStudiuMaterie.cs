﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class ProgramStudiuMaterie
    {
        public int IdProgramStudiu { get; set; }
        public int IdMaterie { get; set; }

        #region Constructors
        public ProgramStudiuMaterie()
        {
        }

        public ProgramStudiuMaterie(int idProgram = 0, int idMaterie = 0)
        {
            this.IdProgramStudiu = idProgram;
            this.IdMaterie = idMaterie;
        }

        public ProgramStudiuMaterie(DataRow linieDB)
        {
            this.IdProgramStudiu = Convert.ToInt32(linieDB["IdProgramStudiu"]);
            this.IdMaterie = Convert.ToInt32(linieDB["IdMaterie"]);
        }

        #endregion
    }
}
