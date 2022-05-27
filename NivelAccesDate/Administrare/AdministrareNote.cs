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
    public class AdministrareNote : IStocareNote
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        // tabele
        private readonly string _tableNameNote = ConfigurationManager.AppSettings.Get("TableNameNote");
        private readonly string _tableNameMaterii = ConfigurationManager.AppSettings.Get("TableNameMaterii");
        private readonly string _tableNameStudenti = ConfigurationManager.AppSettings.Get("TableNameStudenti");
        private readonly string _tableNameFacultati = ConfigurationManager.AppSettings.Get("TableNameFacultati");


        public bool AddNote(Note note)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_tableNameNote} VALUES (:NotaLaborator, :NotaCurs, :NotaFinala, :IdMaterie, :IdStudent)", CommandType.Text,
                new OracleParameter(":NotaLaborator", OracleDbType.Varchar2, note.NotaLaborator, ParameterDirection.Input),
                new OracleParameter(":NotaCurs", OracleDbType.Varchar2, note.NotaCurs, ParameterDirection.Input),
                new OracleParameter(":NotaFinala", OracleDbType.Varchar2, note.NotaFinala, ParameterDirection.Input),
                new OracleParameter(":IdMaterie", OracleDbType.Varchar2, note.IdMaterie, ParameterDirection.Input),
                new OracleParameter(":IdStudent", OracleDbType.Int32, note.IdStudent, ParameterDirection.Input)
                );
        }
        public Note GetNote(int idStudent, int idMaterie)
        {
            Note noteStudent = null;

            var dsNote = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableNameNote} WHERE IdStudent = :IdStudent AND IdMaterie = :IdMaterie", CommandType.Text,
                new OracleParameter(":IdStudent", OracleDbType.Int32, idStudent, ParameterDirection.Input),
                new OracleParameter(":IdMaterie", OracleDbType.Int32, idMaterie, ParameterDirection.Input)
                );

            if (dsNote.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsNote.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                noteStudent = new Note(linieDB);
            }
            return noteStudent;
        }


        public List<Note> GetNote()
        {
            var result = new List<Note>();

            var dsNote = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {_tableNameNote}", CommandType.Text);

            foreach (DataRow linieDB in dsNote.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Note(linieDB));
            }
            return result;
        }

        public DataSet GetNoteStudent(int idStudent)
        {
            var dsMateriiNote = SqlDBHelper.ExecuteDataSet(
                $"SELECT m.idmaterie, m.denumire, m.an, m.semestru, m.procentlaborator, m.procentcurs, " +
                $"n.notalaborator, n.notacurs, n.notafinala " +
                $"FROM {_tableNameMaterii} m, {_tableNameNote} n " +
                $"WHERE n.idstudent = idstudent and n.idmaterie = m.idmaterie", CommandType.Text);
            return dsMateriiNote;
        }

        public DataSet GetNoteStudent(Student student)
        {
            var dsMateriiNote = SqlDBHelper.ExecuteDataSet(
                $"SELECT m.idmaterie, m.denumire, m.an, m.semestru, m.procentlaborator, m.procentcurs, " +
                $"n.notalaborator, n.notacurs, n.notafinala " +
                $"FROM {_tableNameMaterii} m, {_tableNameNote} n, {_tableNameFacultati} f" +
                $"WHERE f.idfacultate = {student.IdFacultate} and f.idfacultate = m.idfacultate", CommandType.Text);
            return dsMateriiNote;
        }

        public bool UpdateNote(Note note)
        {
            throw new NotImplementedException();
        }
    }
}
