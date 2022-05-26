using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using NivelAccesDate;
using NivelAccesDate.Administrare;

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

                        if (tipEntitate == typeof(Facultate))
                        {
                            return new AdministrareFacultati();
                        }

                        if(tipEntitate == typeof(Student))
                        {
                            return new AdministrareStudenti();
                        }

                        if (tipEntitate == typeof(Materie))
                        {
                            return new AdministrareMaterii();
                        }
                        if (tipEntitate == typeof(Note))
                        {
                            return new AdministrareNote();
                        }
                        break;

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
