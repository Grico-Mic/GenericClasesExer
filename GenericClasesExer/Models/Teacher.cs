using System.Collections.Generic;

namespace GenericClasesExer.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<string> SubjectsTeaching { get; set; }

    }
}
