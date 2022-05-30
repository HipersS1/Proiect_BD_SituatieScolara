using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareProgramStudiuMaterie:IStocareFactory
    {
        List<ProgramStudiuMaterie> GetMateriiProgramStudiu(int idProgramStudiu);
        DataSet GetDetaliiMateriiProgramStudiu(int idProgramStudiu);
        DataSet GetDetaliiMateriiProgramStudiuDiferite(int idProgramStudiu);
        ProgramStudiuMaterie GetProgramStudiu(int idProgram, int idMaterie);
        bool AddProgramMaterie(ProgramStudiuMaterie programStudiu);
        bool UpdateProgramMaterie(ProgramStudiuMaterie programStudiu);
        bool DeleteProgramMaterie(ProgramStudiuMaterie programStudiu);
        bool DeleteAllProgramMaterii(int idProgramStudiu);
    }
}
