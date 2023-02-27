
using System.Collections.Generic;


namespace GenericClasesExer.Models
{
    public class Classroom : BaseModel
    {
       
        public int Capacity { get; set; }
        public List<string> ApplicableSubject { get; set; }


    }
}
