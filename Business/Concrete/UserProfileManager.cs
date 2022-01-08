using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repoUser = new Repository<Author>();

        public List<Author> GetAuthorByMail(string p)
        {
            return repoUser.List(x => x.AuthorGmail == p);
        }
    }
}
