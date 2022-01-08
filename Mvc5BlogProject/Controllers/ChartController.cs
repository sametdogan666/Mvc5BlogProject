using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Concrete;
using Mvc5BlogProject.Models;

namespace Mvc5BlogProject.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisualizeResult()
        {
            return Json(categoryList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult VisualizeResult2()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<Class1> categoryList()
        {
            List<Class1> c = new List<Class1>();
            c.Add(new Class1()
            {
                CategoryName = "Teknoloji",
                BlogCount = 14
            });
            c.Add(new Class1()
            {
                CategoryName = "Spor",
                BlogCount = 10
            });
            c.Add(new Class1()
            {
                CategoryName = "Kitap",
                BlogCount = 16
            });
            return c;
        }

        public List<Class2> BlogList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var context = new BlogContext())
            {
                cs2 = context.Blogs.Select(x => new Class2
                {
                    BlogName = x.BlogTitle,
                    Raiting = x.BlogRating
                }).ToList();
            }

            return cs2;
        }

        public ActionResult Chart1()
        {
            return View();
        }

        public ActionResult Chart2()
        {
            return View();
        }
    }
}