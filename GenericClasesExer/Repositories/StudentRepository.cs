using GenericClasesExer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasesExer.Repositories
{
    public class StudentRepository
    {
        public StudentRepository()
        {
            Students = new List<Student>();
        }
        private List<Student> Students;

        public void Create(Student student)
        {
            Students.Add(student);
        }

        public void Delete(Student student)
        {
            Students.Remove(student);
        }
    }
}
