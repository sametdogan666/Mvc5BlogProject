using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repositoryAuthor = new Repository<Author>();

        public List<Author> GetAll()
        {
            return repositoryAuthor.List();
        }
    }
}
