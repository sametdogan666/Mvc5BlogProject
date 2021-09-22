using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;

namespace Mvc5BlogProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            AboutManager aboutManager = new AboutManager();
            var aboutContent = aboutManager.GetAll();
            return View(aboutContent);
        }

        public PartialViewResult Footer()
        {
            AboutManager aboutManager = new AboutManager();
            var aboutContentList = aboutManager.GetAll();
            return PartialView(aboutContentList);
        }

        public PartialViewResult MeetTheTeam()
        {
            AuthorManager authorManager = new AuthorManager();
            var authorList = authorManager.GetAll();
            return PartialView(authorList);
        }
    }
}