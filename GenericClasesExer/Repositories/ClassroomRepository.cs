using GenericClasesExer.Models;
using System.Collections.Generic;


namespace GenericClasesExer.Repositories
{
   public  class ClassroomRepository
    {
        public ClassroomRepository()
        {
            Classroom = new List<Classroom>();
        }

        private List<Classroom> Classroom;

        public void Create(Classroom classroom)
        {
            Classroom.Add(classroom);
        }

        public void Delete(Classroom classroom)
        {
            Classroom.Remove(classroom);
        }

        public List<Classroom> GetAll()
        {
            return Classroom;
        }
    }
}
