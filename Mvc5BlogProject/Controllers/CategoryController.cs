using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;

namespace Mvc5BlogProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryValues = categoryManager.GetAll();
            return View(categoryValues);
        }

        [AllowAnonymous]
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryValues = categoryManager.GetAll();
            return PartialView(categoryValues);
        }

        public ActionResult AdminCategoryList()
        {
            var categoryList = categoryManager.GetAll();
            return View(categoryList);
        }

        [HttpGet]
        public ActionResult AdminCategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminCategoryAdd(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid)
            {
                categoryManager.Add(category);
                return RedirectToAction("AdminCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }

        [HttpGet]
        public ActionResult CategoryEdit(int id)
        {
            Category category = categoryManager.FindCategory(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult CategoryEdit(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid)
            {
                categoryManager.Update(category);
                return RedirectToAction("AdminCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }

        public ActionResult CategoryDelete(int id)
        {
            categoryManager.CategoryStatusFalse(id);
            return RedirectToAction("AdminCategoryList");
        }

        public ActionResult CategoryStatusTrue(int id)
        {
            categoryManager.CategoryStatusTrue(id);
            return RedirectToAction("AdminCategoryList");
        }
    }
}