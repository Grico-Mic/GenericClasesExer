using GenericClasesExer.Models;
using System.Collections.Generic;
using System.Linq;

namespace GenericClasesExer.Repositories
{
    public abstract class BaseRepository<T> where T : BaseModel

    {
        public BaseRepository()
        {
            Data = new List<T>();
        }
        protected List<T> Data { get; set; }

        public void Create(T entity)
            
        {
            Data.Add(entity);
        }

        public void Create(List<T> entityes)
        {
            Data.AddRange(entityes);
        }


        public void Delete(T entity)
        {
            Data.Remove(entity);
        }


        public List<T> GetAll()
        {
            return Data;
        }

        public T GetById(int id)
        {
            return Data.FirstOrDefault(x => x.Id == id);

        }
    }
}
