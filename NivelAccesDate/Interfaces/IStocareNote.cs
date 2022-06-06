using System.Collections.Generic;
using System.Data;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareNote: IStocareFactory
    {
        Note GetNote(int idStudent, int idMaterie);
        DataSet GetNoteStudent(int idStudent);
        List<Note> GetNoteStudentList(int idStudent);
        bool AddNote(Note note);
        bool UpdateNote(Note note);
        bool DeleteNote(int idStudent);
    }
}
