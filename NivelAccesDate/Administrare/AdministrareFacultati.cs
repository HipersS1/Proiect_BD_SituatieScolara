using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace NivelAccesDate
{
    /// <summary>
    /// CRUD pentru datele despre facultati
    /// </summary>
    public class AdministrareFacultati : IStocareFacultati
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        private readonly string _tableName = ConfigurationManager.AppSettings.Get("TableNameFacultati");
        private readonly string _tableSequence = ConfigurationManager.AppSettings.Get("TableSequenceFacultati");

        /// <summary>
        /// Adauga facultate
        /// </summary>
        /// <param name="facultate"></param>
        /// <returns></returns>
        public bool AddFacultate(Facultate facultate)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_tableName} VALUES ({_tableSequence}.NEXTVAL, :Denumire)", CommandType.Text,
                new OracleParameter(":Denumire", OracleDbType.Varchar2, facultate.Denumire, ParameterDirection.Input)          
                );
        }
        /// <summary>
        /// Obtine facultatea cu id-ul respectiv
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Facultate GetFacultate(int id)
        {
            Facultate result = null;

            var dsFacultati = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName} WHERE IdFacultate = :IdFacultate", CommandType.Text,
                new OracleParameter(":IdFacultate", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsFacultati.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsFacultati.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Facultate(linieDB);
            }
            return result;
        }
        
        /// <summary>
        /// Obtine o lista cu facultatile
        /// </summary>
        /// <returns></returns>
        public List<Facultate> GetFacultati()
        {
            var result = new List<Facultate>();
            var dsFacultati = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName}", CommandType.Text);

            foreach (DataRow linieDB in dsFacultati.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Facultate(linieDB));
            }
            return result;
        }

        /// <summary>
        /// Sterge facultatea cu id-ul respectiv
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteFacultate(int id)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"DELETE FROM {_tableName} WHERE IdFacultate = :IdFacultate", CommandType.Text,
                new OracleParameter(":IdFacultate", OracleDbType.Int32, id, ParameterDirection.Input));
        }
        
        /// <summary>
        /// Obtine lista cu facultati - Search dupa anumite campuri
        /// </summary>
        /// <param name="searchString"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public List<Facultate> GetFacultati(List<SearchElement> searchElements)
        {
            return SearchDB<Facultate>.GetSpecificElements(searchElements, _tableName);
        }

        /// <summary>
        /// Pentru actualizarea facultatii - denumire
        /// </summary>
        /// <param name="facultate"></param>
        /// <returns></returns>
        public bool UpdateFacultate(Facultate facultate)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"UPDATE {_tableName} SET Denumire = :Denumire WHERE IdFacultate = :IdFacultate", CommandType.Text,
                new OracleParameter(":Denumire", OracleDbType.Varchar2, facultate.Denumire, ParameterDirection.Input),
                new OracleParameter(":IdFacultate", OracleDbType.Int32, facultate.IdFacultate, ParameterDirection.Input)
                );
        }

        /// <summary>
        /// Cauta in bd daca facultatea daca o facultate cu aceeasi denumire, program studiu si specializare exista deja
        /// </summary>
        /// <param name="facultate"></param>
        /// <returns>true daca exista altfel false</returns>
        public bool ValideazaExistenta(Facultate facultate)
        {
            var dsFacultate = SqlDBHelper.ExecuteDataSet(
                $"SELECT * FROM {_tableName} WHERE Denumire = '{facultate.Denumire}'", 
                CommandType.Text);

            return dsFacultate.Tables[PRIMUL_TABEL].Rows.Count > 0  ? true : false;
        }
    }
}
