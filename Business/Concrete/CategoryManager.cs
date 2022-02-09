using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        Repository<Category> repoCategory = new Repository<Category>();

        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public List<Category> GetAll()
        {
            return _categoryDal.List();
        }

        public void Add(Category category)
        {
            _categoryDal.Insert(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Delete(category);
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
            if (category.CategoryName == "" || category.CategoryName.Length <= 3 || category.CategoryDescription.Length <= 20)
            {
                return -1;
            }
            _category.CategoryName = category.CategoryName;
            _category.CategoryDescription = category.CategoryDescription;

            return repoCategory.Update(_category);
        }

        public int CategoryStatusFalse(int id)
        {
            Category _category = repoCategory.Find(x => x.CategoryId == id);

            _category.CategoryStatus = false;

            return repoCategory.Update(_category);
        }

        public int CategoryStatusTrue(int id)
        {
            Category _category = repoCategory.Find(x => x.CategoryId == id);

            _category.CategoryStatus = true;

            return repoCategory.Update(_category);
        }
    }
}
