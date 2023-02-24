using GenericClasesExer.Models;
using GenericClasesExer.Repositories;
using System;
using System.Collections.Generic;

namespace GenericClasesExer
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            student1.Id = 1;
            student1.Name = "Chuck";
            student1.Surname = "Noris";
            student1.Subjects = new List<string>() { "Math","History"};

            var student2 = new Student()
            {
                Id = 2,
                Name = "Bruce",
                Surname = "Lee",
                Subjects = new List<string>() { "Muzic","Art"}
            };

            var studentRepositories = new StudentRepository();
            studentRepositories.Create(student1);
            studentRepositories.Create(student2);

            var studentList = new List<Student> { student1, student2 };
            studentRepositories.Create(studentList);

            studentRepositories.Delete(student1);


        }
    }
}
