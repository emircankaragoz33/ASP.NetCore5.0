using DAL.Abstract;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Concrete
{
    public class GenericRepository<T> :IGenericDal<T> where T: class
    {
      
        public void Add(T entity)
        {
            using var context = new YazilimContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new YazilimContext();
           return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new YazilimContext();
           return context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            using var context = new YazilimContext();
            context.Update(entity);
            context.SaveChanges();
        }

       public void Delete(T Entity)
        {
            using var context = new YazilimContext();
            context.Remove(Entity);
            context.SaveChanges();
        }
    }
}
