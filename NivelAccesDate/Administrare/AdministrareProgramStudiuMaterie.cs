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
        private readonly string _tableNameMaterii = ConfigurationManager.AppSettings.Get("TableNameMaterii");

        public bool AddProgramMaterie(ProgramStudiuMaterie program)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_tableName} VALUES (:IdProgramStudiu, :IdMaterie)", CommandType.Text,
                new OracleParameter(":IdProgramStudiu", OracleDbType.Int32, program.IdProgramStudiu, ParameterDirection.Input),
                new OracleParameter(":IdMaterie", OracleDbType.Int32, program.IdMaterie, ParameterDirection.Input)
                );
        }

        public bool DeleteProgramMaterie(ProgramStudiuMaterie programStudiu)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"DELETE FROM {_tableName} WHERE IdProgramStudiu = :IdProgramStudiu AND IdMaterie = :IdMaterie", CommandType.Text,
                new OracleParameter(":IdProgramStudiu", OracleDbType.Int32, programStudiu.IdProgramStudiu, ParameterDirection.Input),
                new OracleParameter(":IdMaterie", OracleDbType.Int32, programStudiu.IdMaterie, ParameterDirection.Input)
                );
        }
        public bool DeleteAllProgramMaterii(int idProgramStudiu)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"DELETE FROM {_tableName} where IdProgramStudiu = :IdProgramStudiu", CommandType.Text,
                new OracleParameter(":IdProgramStudiu", OracleDbType.Int32, idProgramStudiu, ParameterDirection.Input));
        }

        public List<ProgramStudiuMaterie> GetMateriiProgramStudiu(int idProgramStudiu)
        {
            var result = new List<ProgramStudiuMaterie>();
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName} WHERE IdProgramStudiu = {idProgramStudiu}", CommandType.Text);

            foreach (DataRow linieDB in dsPrograme.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new ProgramStudiuMaterie(linieDB));
            }
            return result;
        }

        public DataSet GetDetaliiMateriiProgramStudiu(int idProgramStudiu)
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT m.* FROM {_tableNameMaterii} m, {_tableName} pm WHERE pm.IdProgramStudiu = {idProgramStudiu} AND pm.IdMaterie = m.IdMaterie", CommandType.Text);
            return dsPrograme;
        }
        public DataSet GetDetaliiMateriiProgramStudiuDiferite(int idProgramStudiu)
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT m.* FROM {_tableNameMaterii} m where m.idmaterie != ALL (select idmaterie from {_tableName} where IdProgramStudiu = {idProgramStudiu})", CommandType.Text);
            return dsPrograme;
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
