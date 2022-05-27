using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareMaterii: IStocareFactory
    {
        List<Materie> GetMaterii();
        DataSet GetMateriiSearch(List<SearchElement> searchElements);
        Materie GetMaterie(int id);
        bool AddMaterie(Materie materie);
        bool UpdateMaterie(Materie materie);
        bool DeleteMaterie(int id);
        bool tobedeleted();
        DataSet GetMateriiFacultati();
        bool ValideazaExistenta(Materie materie);
    }
}
