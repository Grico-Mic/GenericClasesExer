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

            var student2 = new Student();
            student2.Id = 2;
            student2.Name = "Bruce";
            student2.Surname = "Lee";
            student2.Subjects = new List<string>() { "Music", "Art" };
            


            var studentRepositories = new StudentRepository();
            studentRepositories.Create(student1);
            studentRepositories.Create(student2);


            var studentList = new List<Student> {student1, student2};
            studentRepositories.Create(studentList);

            studentRepositories.Delete(student1);

           

            var students = studentRepositories.GetAll();

            foreach (var item in students)
            {
                Console.WriteLine(item.Name);
            }


            var classroom1 = new Classroom();
            classroom1.Id = 1;
            classroom1.Capacity = 30;
            classroom1.ApplicableSubject = new List<string>() { "Math", "Programming" };

            var classroom2 = new Classroom()
            {
                Id = 2,
                Capacity = 50,
                ApplicableSubject = new List<string>() { "Chemistry" }
            };

            var classroomRepository = new ClassroomRepository();

            classroomRepository.Create(classroom1);
            classroomRepository.Create(classroom2);
            classroomRepository.Delete(classroom1);
            var classrooms = classroomRepository.GetAll();

            classrooms.ForEach(x => Console.WriteLine(x.Id));
        }
    }
}
