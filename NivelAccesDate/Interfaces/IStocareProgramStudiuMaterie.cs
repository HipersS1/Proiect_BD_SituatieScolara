using LibrarieModele;
using System.Collections.Generic;
using System.Data;

namespace NivelAccesDate
{
    public interface IStocareProgramStudiuMaterie:IStocareFactory
    {
        List<ProgramStudiuMaterie> GetMateriiProgramStudiu(int idProgramStudiu);
        DataSet GetDetaliiMateriiProgramStudiu(int idProgramStudiu);
        DataSet GetDetaliiMateriiProgramStudiuDiferite(ProgramStudiu programStudiu);
        ProgramStudiuMaterie GetProgramStudiu(int idProgram, int idMaterie);
        bool AddProgramMaterie(ProgramStudiuMaterie programStudiu);
        bool UpdateProgramMaterie(ProgramStudiuMaterie programStudiu);
        bool DeleteProgramMaterie(ProgramStudiuMaterie programStudiu);
        bool DeleteAllProgramMaterii(int idProgramStudiu);
    }
}
