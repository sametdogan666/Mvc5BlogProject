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

        public Category FindCategory(int id)
        {
            return repoCategory.Find(x => x.CategoryId == id);
        }

        public int EditCategory(Category category)
        {
            Category _category = repoCategory.Find(x => x.CategoryId == category.CategoryId);
            if (category.CategoryName == "" || category.CategoryName.Length <=3 || category.CategoryDescription.Length <= 20)
            {
                return -1;
            }
            _category.CategoryName = category.CategoryName;
            _category.CategoryDescription = category.CategoryDescription;

            return repoCategory.Update(_category);
        }
    }
}
