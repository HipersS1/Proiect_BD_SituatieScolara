using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public static class Ciclu
    {
        public static readonly string Licenta = "Licenta";
        public static readonly string Masterat = "Masterat";
        public static readonly string Doctorat = "Doctorat";
        public static readonly string Postuniversitar = "Postuniversitar";


        public static List<string> GetProgrameStudii()
        {
            return new List<string> { Licenta, Masterat, Doctorat, Postuniversitar };
        }
    }


}
