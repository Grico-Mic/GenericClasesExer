using System.Collections.Generic;

namespace GenericClasesExer.Models
{
    public class Teacher : BaseModel
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<string> SubjectsTeaching { get; set; }

    }
}
