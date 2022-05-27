using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareNote: IStocareFactory
    {
        List<Note> GetNote();
        Note GetNote(int idStudent, int idMaterie);
        DataSet GetNoteStudent(int idStudent);
        DataSet GetNoteStudent(Student student);
        bool AddNote(Note note);
        bool UpdateNote(Note note);
    }
}
