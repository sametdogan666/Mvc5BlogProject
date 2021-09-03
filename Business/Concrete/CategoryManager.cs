using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager
    {
        Repository<Category> repoCategory = new Repository<Category>();
        public List<Category> GetAll()
        {
            return repoCategory.List();
        }
    }
}
