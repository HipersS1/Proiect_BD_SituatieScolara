using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using NivelAccesDate;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareMaterii : IStocareMaterii
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        private readonly string _tableName = ConfigurationManager.AppSettings.Get("TableNameMaterii");
        private readonly string _tableNameFacultate = ConfigurationManager.AppSettings.Get("TableNameFacultati");
        private readonly string _tableNameProgrameStudii = ConfigurationManager.AppSettings.Get("TableNameProgrameStudii");

        private readonly string _tableSequence = ConfigurationManager.AppSettings.Get("TableSequenceMaterii");


        public bool tobedeleted()
        {
            bool secventa = SqlDBHelper.ExecuteNonQuery($"CREATE SEQUENCE {_tableSequence}", CommandType.Text);

            bool tabel = SqlDBHelper.ExecuteNonQuery(
                $"CREATE TABLE {_tableName}( IdMaterie NUMBER PRIMARY KEY, Denumire VARCHAR2(50) NOT NULL, An NUMBER(1) NOT NULL, " +
                $"Semestru NUMBER(1) NOT NULL,ProcentLaborator NUMBER(2) NOT NULL,ProcentCurs NUMBER(2) NOT NULL, " +
                $"IdFacultate NUMBER CONSTRAINT nn_materii_facultati_brumaS not null CONSTRAINT fk_materii_facultati_brumaS references facultati_brumaS (IdFacultate))", CommandType.Text
                );

            if (secventa && tabel)
                return true;
            return false;
        }

        #region CRUD
        public bool AddMaterie(Materie materie)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_tableName} VALUES ({_tableSequence}.NEXTVAL, :Denumire, :An, :Semestru, :ProcentLaborator, :ProcentCurs)", CommandType.Text,
                new OracleParameter(":Denumire", OracleDbType.Varchar2, materie.Denumire, ParameterDirection.Input),
                new OracleParameter(":An", OracleDbType.Varchar2, materie.An, ParameterDirection.Input),
                new OracleParameter(":Semestru", OracleDbType.Varchar2, materie.Semestru, ParameterDirection.Input),
                new OracleParameter(":ProcentLaborator", OracleDbType.Varchar2, materie.ProcentLaborator, ParameterDirection.Input),
                new OracleParameter(":ProcentCurs", OracleDbType.Int32, materie.ProcentCurs, ParameterDirection.Input)
                );
        }

        public Materie GetMaterie(int id)
        {
            Materie materie = null;

            var dsMaterii = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName} WHERE IdMaterie = :IdMaterie", CommandType.Text,
                new OracleParameter(":IdMaterie", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsMaterii.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsMaterii.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                materie = new Materie(linieDB);
            }
            return materie;
        }

        public List<Materie> GetMaterii()
        {
            var result = new List<Materie>();

            var dsMaterii = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName}", CommandType.Text);

            foreach (DataRow linieDB in dsMaterii.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Materie(linieDB));
            }
            return result;
        }
        public DataSet GetMateriiDataSet()
        {
            var dsMaterii = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName}", CommandType.Text);
            return dsMaterii;
        }

        public bool UpdateMaterie(Materie materie)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"UPDATE {_tableName} SET Denumire = :Denumire, An = :An, Semestru = :Semestru, ProcentLaborator = :ProcentLaborator, ProcentCurs = :ProcentCurs " +
                $"WHERE IdMaterie = :IdMaterie", CommandType.Text,
                new OracleParameter(":Denumire", OracleDbType.Varchar2, materie.Denumire, ParameterDirection.Input),
                new OracleParameter(":An", OracleDbType.Int32, materie.An, ParameterDirection.Input),
                new OracleParameter(":Semestru", OracleDbType.Int32, materie.Semestru, ParameterDirection.Input),
                new OracleParameter(":ProcentLaborator", OracleDbType.Int32, materie.ProcentLaborator, ParameterDirection.Input),
                new OracleParameter(":ProcentCurs", OracleDbType.Int32, materie.ProcentCurs, ParameterDirection.Input),
                new OracleParameter(":IdMaterie", OracleDbType.Int32, materie.IdMaterie, ParameterDirection.Input)
                );
        }

        public bool DeleteMaterie(int id)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"DELETE FROM {_tableName} WHERE IdMaterie = :IdMaterie", CommandType.Text,
                new OracleParameter(":IdMaterie", OracleDbType.Int32, id, ParameterDirection.Input));
        }

        #endregion



        #region Functii

        public bool ValideazaExistenta(Materie materie)
        {
            var dsFacultate = SqlDBHelper.ExecuteDataSet(
                $"SELECT * FROM {_tableName} WHERE Denumire = '{materie.Denumire}' AND An = '{materie.An}' AND Semestru = '{materie.Semestru}'", CommandType.Text);

            return dsFacultate.Tables[PRIMUL_TABEL].Rows.Count > 0 ? true : false;
        }

        public List<Materie> GetMateriiSearch(List<SearchElement> searchElements)
        {
            return SearchDB<Materie>.GetSpecificElements(searchElements, _tableName);
        }

        #endregion
    }
}
