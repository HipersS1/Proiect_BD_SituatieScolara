using System.Collections.Generic;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareFacultati: IStocareFactory
    {
        List<Facultate> GetFacultati();
        Facultate GetFacultate(int id);
        List<Facultate> GetFacultati(List<SearchElement> searchElements);
        bool AddFacultate(Facultate facultate);
        bool UpdateFacultate(Facultate facultate);
        bool DeleteFacultate(int id);
        bool ValideazaExistenta(Facultate facultate);
    }
}
