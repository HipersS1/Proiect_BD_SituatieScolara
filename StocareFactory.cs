using System;
using System.Configuration;
using LibrarieModele;
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

                        if (tipEntitate == typeof(ProgramStudiu))
                        {
                            return new AdministrareProgrameStudii();
                        }

                        if (tipEntitate == typeof(ProgramStudiuMaterie))
                        {
                            return new AdministrareProgramStudiuMaterie();
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
