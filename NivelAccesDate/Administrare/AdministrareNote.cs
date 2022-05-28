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
                new OracleParameter(":NotaLaborator", OracleDbType.Decimal, note.NotaLaborator, ParameterDirection.Input),
                new OracleParameter(":NotaCurs", OracleDbType.Decimal, note.NotaCurs, ParameterDirection.Input),
                new OracleParameter(":NotaFinala", OracleDbType.Int32, note.NotaFinala, ParameterDirection.Input),
                new OracleParameter(":IdMaterie", OracleDbType.Int32, note.IdMaterie, ParameterDirection.Input),
                new OracleParameter(":IdStudent", OracleDbType.Int32, note.IdStudent, ParameterDirection.Input)
                );
        }

        public bool UpdateNote(Note note)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"UPDATE {_tableNameNote} SET NotaLaborator = :NotaLaborator, NotaCurs = :NotaCurs, NotaFinala = :NotaFinala " +
                $"WHERE IdStudent = :IdStudent AND IdMaterie = :IdMaterie", CommandType.Text,
                new OracleParameter(":NotaLaborator", OracleDbType.Decimal, note.NotaLaborator, ParameterDirection.Input),
                new OracleParameter(":NotaCurs", OracleDbType.Decimal, note.NotaCurs, ParameterDirection.Input),
                new OracleParameter(":NotaFinala", OracleDbType.Int32, note.NotaFinala, ParameterDirection.Input),
                new OracleParameter(":IdStudent", OracleDbType.Int32, note.IdStudent, ParameterDirection.Input),
                new OracleParameter(":IdMaterie", OracleDbType.Int32, note.IdMaterie, ParameterDirection.Input)
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


        public List<Note> GetNoteStudent(int idStudent)
        {
            var result = new List<Note>();

            var dsNote = SqlDBHelper.ExecuteDataSet($"SELECT n.*, m.procentlaboator, m.procentcurs FROM {_tableNameNote} n, {_tableNameMaterii} m WHERE IdStudent = {idStudent}", CommandType.Text);

            foreach (DataRow linieDB in dsNote.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Note(linieDB));
            }
            return result;
        }
        
    }
}
