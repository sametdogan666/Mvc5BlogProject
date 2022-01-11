using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using Entities.Concrete;

namespace Mvc5BlogProject.Controllers
{
    [AllowAnonymous]
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

        [HttpGet]
        public ActionResult UpdateAbout()
        {
            AboutManager aboutManager = new AboutManager();
            var aboutList = aboutManager.GetAll();
            return View(aboutList);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            AboutManager aboutManager = new AboutManager();
            aboutManager.UpdateAbout(about);
            return RedirectToAction("UpdateAbout");
        }

    }
}