using GenericClasesExer.Models;
using System.Collections.Generic;

namespace GenericClasesExer.Repositories
{
    public class StudentRepository : BaseRepository<Student>
    {
        public List<string> GetStudentSubjects(int id)
        {
            var student = GetById(id);
            return student.Subjects;
        }
    }
}



 