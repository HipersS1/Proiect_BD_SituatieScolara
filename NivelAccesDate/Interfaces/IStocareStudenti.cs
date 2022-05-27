using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareStudenti: IStocareFactory
    {
        List<Student> GetStudents();
        bool ValideazaExistenta(Student student);
        DataSet GetStudentiFacultati();
        DataSet GetStudents(List<SearchElement> searchElements);
        Student GetStudent(int id);
        bool AddStudent(Student student);
        bool UpdateStudent(Student student);
        bool DeleteStudent(int id);
    }
}
