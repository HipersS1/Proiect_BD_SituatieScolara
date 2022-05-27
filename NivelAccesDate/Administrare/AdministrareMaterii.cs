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
        private readonly string _tableNameFaculty = ConfigurationManager.AppSettings.Get("TableNameFacultati");
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

        public bool AddMaterie(Materie materie)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_tableName} VALUES ({_tableSequence}.NEXTVAL, :Denumire, :An, :Semestru, :ProcentLaborator, :ProcentCurs, :IdFacultate)", CommandType.Text,
                new OracleParameter(":Denumire", OracleDbType.Varchar2, materie.Denumire, ParameterDirection.Input),
                new OracleParameter(":An", OracleDbType.Varchar2, materie.An, ParameterDirection.Input),
                new OracleParameter(":Semestru", OracleDbType.Varchar2, materie.Semestru, ParameterDirection.Input),
                new OracleParameter(":ProcentLaborator", OracleDbType.Varchar2, materie.ProcentLaborator, ParameterDirection.Input),
                new OracleParameter(":ProcentCurs", OracleDbType.Int32, materie.ProcentCurs, ParameterDirection.Input),
                new OracleParameter(":IdFacultate", OracleDbType.Int32, materie.IdFacultate, ParameterDirection.Input)
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


        public DataSet GetMateriiFacultati()
        {
            var dsStudenti = SqlDBHelper.ExecuteDataSet($"SELECT m.idmaterie, m.denumire, m.an, m.semestru, m.procentlaborator, m.procentcurs, " +
                                                        $"f.denumire || ' ' || f.programstudiu || ' ' || f.specializare as Facultate " +
                                                        $"FROM {_tableName} m, {_tableNameFaculty} f WHERE m.idfacultate = f.idfacultate", CommandType.Text);
            return dsStudenti;
        }

        public DataSet GetMateriiSearch(List<SearchElement> searchElements)
        {
            StringBuilder conditions = new StringBuilder();

            foreach (var item in searchElements)
            {
                int number;
                if (Int32.TryParse(item.Value, out number))
                    conditions.Append($"{item.ColumnName} = {number} AND ");
                else
                    conditions.Append($"UPPER({item.ColumnName.ToUpper()}) LIKE '%{item.Value.ToUpper()}%' AND ");
            }

            conditions = conditions.Remove(conditions.Length - 4, 3);
            Console.WriteLine(conditions.ToString());
            var dsStudenti = SqlDBHelper.ExecuteDataSet($"SELECT m.idmaterie, m.denumire, m.an, m.semestru, m.procentlaborator, m.procentcurs, " +
                $"f.denumire || ' ' || f.programstudiu || ' ' || f.specializare as Facultate " +
                $"FROM {_tableName} M, {_tableNameFaculty} F WHERE {conditions} AND M.IDFACULTATE = F.IDFACULTATE", CommandType.Text);


            return dsStudenti;
        }

        public bool ValideazaExistenta(Materie materie)
        {
            var dsFacultate = SqlDBHelper.ExecuteDataSet(
                $"SELECT * FROM {_tableName} WHERE Denumire = '{materie.Denumire}' AND An = '{materie.An}' AND Semestru = '{materie.Semestru}' AND " +
                $"IdFacultate = {materie.IdFacultate}",
                CommandType.Text);

            return dsFacultate.Tables[PRIMUL_TABEL].Rows.Count > 0 ? true : false;
        }

        public bool DeleteMaterie(int id)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"DELETE FROM {_tableName} WHERE IdMaterie = :IdMaterie", CommandType.Text,
                new OracleParameter(":IdMaterie", OracleDbType.Int32, id, ParameterDirection.Input));
        }
    }
}
