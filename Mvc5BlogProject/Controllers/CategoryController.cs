using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;

namespace Mvc5BlogProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            var categoryValues = categoryManager.GetAll();
            return View(categoryValues);
        }

        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryValues = categoryManager.GetAll();
            return PartialView(categoryValues);
        }
    }
}