using GenericClasesExer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasesExer.Repositories
{
    public class TeacherRepository
    {
        public TeacherRepository()
        {
            Teacher = new List<Teacher>();
        }

        private List<Teacher> Teacher;

        internal void Create(Teacher teacher)
        {
            Teacher.Add(teacher);
        }

        internal void Delete(Teacher teacher)
        {
            Teacher.Remove(teacher);
        }

        public List<Teacher> GetAll()
        {
            return Teacher;
        }
    }    
}
