﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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
        public void Delete(T p)
        {
            _object.Remove(p);
            blogContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public T Find(Expression<Func<T, bool>> @where)
        {
            return _object.FirstOrDefault(where);
        }

        public void Insert(T p)
        {
            _object.Add(p);
            blogContext.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public void Update(T p)
        {
            blogContext.SaveChanges();
        }
    }
}
