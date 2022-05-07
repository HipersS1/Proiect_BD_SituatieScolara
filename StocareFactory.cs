using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelAccesDate;

namespace Proiect_BD_SituatieScolara
{
    public class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":

                        //if (tipEntitate == typeof(Companie))
                        //{
                        //    return new AdministrareCompanii();
                        //}
                        //if (tipEntitate == typeof(Masina))
                        //{
                        //    return new AdministrareMasini();
                        //}
                        //break;

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
