using LibrarieModele;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public class AdministrareProgramStudiuMaterie : IStocareProgramStudiuMaterie
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        private readonly string _tableName = ConfigurationManager.AppSettings.Get("TableNameProgramMaterie");

        public bool AddProgramMaterie(ProgramStudiuMaterie program)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_tableName} VALUES (:IdProgramStudiu, :IdMaterie)", CommandType.Text,
                new OracleParameter(":IdProgramStudiu", OracleDbType.Int32, program.IdProgramStudiu, ParameterDirection.Input),
                new OracleParameter(":IdMaterie", OracleDbType.Int32, program.IdMaterie, ParameterDirection.Input)
                );
        }

        public bool DeleteProgramMaterie(int idProgram, int idMaterie)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"DELETE FROM {_tableName} WHERE IdProgramStudiu = :IdProgramStudiu AND IdMaterie = :IdMaterie", CommandType.Text,
                new OracleParameter(":IdProgramStudiu", OracleDbType.Int32, idProgram, ParameterDirection.Input),
                new OracleParameter(":IdMaterie", OracleDbType.Int32, idMaterie, ParameterDirection.Input)
                );
        }

        public List<ProgramStudiuMaterie> GetProgramMaterie()
        {
            var result = new List<ProgramStudiuMaterie>();
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName}", CommandType.Text);

            foreach (DataRow linieDB in dsPrograme.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new ProgramStudiuMaterie(linieDB));
            }
            return result;
        }

        public ProgramStudiuMaterie GetProgramStudiu(int idProgram, int idMaterie)
        {
            ProgramStudiuMaterie result = null;

            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName} WHERE IdProgramStudiu = :IdProgramStudiu AND IdMaterie = :IdMaterie", CommandType.Text,
                new OracleParameter(":IdProgramStudiu", OracleDbType.Int32, idProgram, ParameterDirection.Input),
                new OracleParameter(":IdMaterie", OracleDbType.Int32, idMaterie, ParameterDirection.Input)
                );

            if (dsPrograme.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsPrograme.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new ProgramStudiuMaterie(linieDB);
            }
            return result;
        }

        public bool UpdateProgramMaterie(ProgramStudiuMaterie programStudiu)
        {
            throw new NotImplementedException();
        }
    }
}
