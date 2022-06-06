using LibrarieModele;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareProgrameStudii:IStocareFactory
    {
        List<ProgramStudiu> GetProgrameStudii();
        ProgramStudiu GetProgramStudiu(int id);
        List<ProgramStudiu> GetProgrameStudii(List<SearchElement> searchElements);
        bool AddProgramStudiu(ProgramStudiu programStudiu);
        bool UpdateProgramStudiu(ProgramStudiu programStudiu);
        bool DeleteProgramStudiu(int id);
        bool DeleteProgrameStudii(int idFacultate);
        bool ValideazaExistenta(ProgramStudiu programStudiu);
    }
}
