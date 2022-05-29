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
        DataSet GetMateriiDataSet();
        List<Materie> GetMateriiSearch(List<SearchElement> searchElements);
        Materie GetMaterie(int id);
        bool AddMaterie(Materie materie);
        bool UpdateMaterie(Materie materie);
        bool DeleteMaterie(int id);
        bool tobedeleted();
        bool ValideazaExistenta(Materie materie);
    }
}
