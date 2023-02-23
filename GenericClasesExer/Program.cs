using GenericClasesExer.Models;
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

        }
    }
}
