using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}