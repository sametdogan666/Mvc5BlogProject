using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {

        BlogContext blogContext = new BlogContext();
        private DbSet<T> _object;

        public Repository()
        {
            _object = blogContext.Set<T>();
        }
        public int Delete(T p)
        {
            _object.Remove(p);
            return blogContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return blogContext.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public int Update(T p)
        {
            return blogContext.SaveChanges();
        }
    }
}
