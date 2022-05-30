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
    public class AdministrareProgrameStudii : IStocareProgrameStudii
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        private readonly string _tableName = ConfigurationManager.AppSettings.Get("TableNameProgrameStudii");
        private readonly string _tableSequence = ConfigurationManager.AppSettings.Get("TableSequenceProgrameStudii");

        public bool AddProgramStudiu(ProgramStudiu programStudiu)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_tableName} VALUES ({_tableSequence}.NEXTVAL, :Ciclu, :Specializare, :Durata, :IdFacultate)", CommandType.Text,
                new OracleParameter(":Ciclu", OracleDbType.Varchar2, programStudiu.Ciclu, ParameterDirection.Input),
                new OracleParameter(":Specializare", OracleDbType.Varchar2, programStudiu.Specializare, ParameterDirection.Input),
                new OracleParameter(":Durata", OracleDbType.Int32, programStudiu.Durata, ParameterDirection.Input),
                new OracleParameter(":IdFacultate", OracleDbType.Int32, programStudiu.IdFacultate, ParameterDirection.Input)
                );
        }

        public List<ProgramStudiu> GetProgrameStudii()
        {
            var result = new List<ProgramStudiu>();
            var dsPrograme= SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName}", CommandType.Text);

            foreach (DataRow linieDB in dsPrograme.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new ProgramStudiu(linieDB));
            }
            return result;
        }

        public ProgramStudiu GetProgramStudiu(int id)
        {
            ProgramStudiu result = null;

            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName} WHERE IdProgramStudiu = :IdProgramStudiu", CommandType.Text,
                new OracleParameter(":IdProgramStudiu", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsPrograme.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsPrograme.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new ProgramStudiu(linieDB);
            }
            return result;
        }

        public bool UpdateProgramStudiu(ProgramStudiu programStudiu)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"UPDATE {_tableName} SET Ciclu = :Ciclu, Specializare = :Specializare, Durata = :Durata WHERE IdProgramStudiu = :IdProgramStudiu", CommandType.Text,
                new OracleParameter(":Ciclu", OracleDbType.Varchar2, programStudiu.Ciclu, ParameterDirection.Input),
                new OracleParameter(":Specializare", OracleDbType.Varchar2, programStudiu.Specializare, ParameterDirection.Input),
                new OracleParameter(":Durata", OracleDbType.Int32, programStudiu.Durata, ParameterDirection.Input),
                new OracleParameter(":IdProgramStudiu", OracleDbType.Int32, programStudiu.IdProgramStudiu, ParameterDirection.Input)
                );
        }

        public bool DeleteProgramStudiu(int id)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"DELETE FROM {_tableName} WHERE IdProgramStudiu = :IdProgramStudiu", CommandType.Text,
                new OracleParameter(":IdProgramStudiu", OracleDbType.Int32, id, ParameterDirection.Input));
        }

        public bool DeleteProgrameStudii(int idFacultate)
        {
            return SqlDBHelper.ExecuteNonQuery($"DELETE FROM {_tableName} WHERE IdFacultate = {idFacultate}", CommandType.Text);
        }


        //

        public bool ValideazaExistenta(ProgramStudiu programStudiu)
        {
            var dsProgram = SqlDBHelper.ExecuteDataSet(
                $"SELECT * FROM {_tableName} WHERE Ciclu = '{programStudiu.Ciclu}' AND Specializare = '{programStudiu.Specializare}' " +
                $"AND IdFacultate = {programStudiu.IdFacultate}",
                CommandType.Text);

            return dsProgram.Tables[PRIMUL_TABEL].Rows.Count > 0 ? true : false;
        }

        public List<ProgramStudiu> GetProgrameStudii(List<SearchElement> searchElements)
        {
            return SearchDB<ProgramStudiu>.GetSpecificElements(searchElements, _tableName);
        }
    }
}
