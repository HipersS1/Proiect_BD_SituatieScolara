using LibrarieModele;
using NivelAccesDate;
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
    public class AdministrareStudenti : IStocareStudenti
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        private readonly string _tableName = ConfigurationManager.AppSettings.Get("TableNameStudenti");
        private readonly string _tableNameFaculty = ConfigurationManager.AppSettings.Get("TableNameFacultati");
        private readonly string _tableSequence = ConfigurationManager.AppSettings.Get("TableSequenceStudenti");

        /// <summary>
        /// Adauga student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool AddStudent(Student student)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_tableName} VALUES ({_tableSequence}.NEXTVAL, :Nume, :Prenume, :Email, :Telefon, :An, :IdFacultate)", CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.Varchar2, student.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.Varchar2, student.Prenume, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.Varchar2, student.Email, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.Varchar2, student.Telefon, ParameterDirection.Input),
                new OracleParameter(":An", OracleDbType.Int32, student.An, ParameterDirection.Input),
                new OracleParameter(":IdFacultate", OracleDbType.Int32, student.IdFacultate, ParameterDirection.Input)
                );
        }

        /// <summary>
        /// Obtine studentul cu id-ul respectiv
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student GetStudent(int id)
        {
            Student student = null;

            var dsStudenti = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName} WHERE IdStudent = :IdStudent", CommandType.Text,
                new OracleParameter(":IdStudent", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsStudenti.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsStudenti.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                student = new Student(linieDB);
            }
            return student;
        }

        /// <summary>
        /// Obtine o lista cu studenti
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudents()
        {
            var result = new List<Student>();

            var dsStudenti = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableName}", CommandType.Text);

            foreach (DataRow linieDB in dsStudenti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Student(linieDB));
            }
            return result;
        }

        public DataSet GetStudents(List<SearchElement> searchElements)
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
            var dsStudenti = SqlDBHelper.ExecuteDataSet($"SELECT S.idstudent, S.nume || ' ' || S.prenume AS Student, S.email, S.telefon, F.denumire || ' ' || F.programstudiu || ' ' || F.specializare as Facultate, S.an " +
                $"FROM {_tableName} S, {_tableNameFaculty} F WHERE {conditions} AND S.IDFACULTATE = F.IDFACULTATE", CommandType.Text);


            return dsStudenti;
        }

        /// <summary>
        /// Preia datale student + facultate din baza de date
        /// </summary>
        /// <returns></returns>
        public DataSet GetStudentiFacultati()
        {
            var dsStudenti = SqlDBHelper.ExecuteDataSet($"SELECT s.idstudent, s.nume || ' ' || s.prenume AS Student, s.email, s.telefon, f.denumire || ' ' || f.programstudiu || ' ' || f.specializare as Facultate, s.an " +
                                                        $"FROM {_tableName} s, {_tableNameFaculty} f WHERE s.idfacultate = f.idfacultate", CommandType.Text);
            return dsStudenti;
        }

        /// <summary>
        /// Actualizeaza student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool UpdateStudent(Student student)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"UPDATE {_tableName} SET Nume = :Nume, Prenume = :Prenume, Email = :Email, Telefon = :Telefon, An = :An " +
                $"WHERE IdStudent = :IdStudent", CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.Varchar2, student.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.Varchar2, student.Prenume, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.Varchar2, student.Email, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.Varchar2, student.Telefon, ParameterDirection.Input),
                new OracleParameter(":An", OracleDbType.Int32, student.An, ParameterDirection.Input),
                new OracleParameter(":IdStudent", OracleDbType.Int32, student.IdStudent, ParameterDirection.Input)
                );
        }


        /// <summary>
        /// Verifica daca studentul exista deja in baza de date
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool ValideazaExistenta(Student student)
        {
            var dsFacultate = SqlDBHelper.ExecuteDataSet(
                $"SELECT * FROM {_tableName} WHERE Nume = '{student.Nume}' AND Prenume = '{student.Prenume}' AND Email = '{student.Email}' AND " +
                $"Telefon = '{student.Telefon}' AND IdFacultate = {student.IdFacultate} AND An = {student.An}",
                CommandType.Text);

            return dsFacultate.Tables[PRIMUL_TABEL].Rows.Count > 0 ? true : false;
        }

        public bool DeleteStudent(int id)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"DELETE FROM {_tableName} WHERE IdStudent = :IdStudent", CommandType.Text,
                new OracleParameter(":IdStudent", OracleDbType.Int32, id, ParameterDirection.Input));
        }
    }
}
