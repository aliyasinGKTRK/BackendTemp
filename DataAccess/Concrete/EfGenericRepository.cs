using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfGenericRepository<T> : IGenericRepository<T>
        where T : class, new()

    {
        public void Add(T entity)
        {
            using (var context = new AppContext())
            {

                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new AppContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new AppContext())
            {

                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new AppContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public IList<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new AppContext())
            {

                return filter == null
                    ? context.Set<T>().ToList()
                    : context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (var context = new AppContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }

        }

    }
}
