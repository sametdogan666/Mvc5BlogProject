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

        public int CategoryAdd(Category category)
        {
            if (category.CategoryName == "" || category.CategoryDescription == "" || category.CategoryName.Length <= 3 || category.CategoryDescription.Length <= 20)
            {
                return -1;
            }

            return repoCategory.Insert(category);
        }
    }
}
