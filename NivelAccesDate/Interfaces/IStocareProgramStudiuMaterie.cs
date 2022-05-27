using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareProgramStudiuMaterie:IStocareFactory
    {
        List<ProgramStudiuMaterie> GetProgramMaterie();
        ProgramStudiuMaterie GetProgramStudiu(int idProgram, int idMaterie);
        bool AddProgramMaterie(ProgramStudiuMaterie programStudiu);
        bool UpdateProgramMaterie(ProgramStudiuMaterie programStudiu);
        bool DeleteProgramMaterie(int idProgram, int idMaterie);
    }
}
