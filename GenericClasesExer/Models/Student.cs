
using System.Collections.Generic;


namespace GenericClasesExer.Models
{
    public class Student : BaseModel
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<string> Subjects { get; set; }


    }
}
