using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;

namespace Mvc5BlogProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager _blogManager = new BlogManager();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BlogList()
        {
            var blogList = _blogManager.GetAll();
            return PartialView(blogList);
        }

        public PartialViewResult FeaturedPosts()
        {
            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }

        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }

        public ActionResult BlogDetails()
        {
            return View();
        }

        public PartialViewResult BlogCover()
        {
            return PartialView();
        }

        public PartialViewResult BlogReadAll()
        {
            return PartialView();
        }

        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}