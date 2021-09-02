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
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T p)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public int Update(T p)
        {
            throw new NotImplementedException();
        }
    }
}
