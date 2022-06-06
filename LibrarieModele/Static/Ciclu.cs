using System.Collections.Generic;

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
