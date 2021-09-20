using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BlogManager
    {
        Repository<Blog> blogRepository = new Repository<Blog>();

        public List<Blog> GetAll()
        {
            return blogRepository.List();
        }

        public List<Blog> BlogById(int id)
        {
            return blogRepository.List().Where(x => x.BlogId == id).ToList();
        }
    }
}
