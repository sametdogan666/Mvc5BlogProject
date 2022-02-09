using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        void Add(Blog blog);
        Blog GetById(int id);
        void Delete(Blog blog);
        void Update(Blog blog);
    }
}
