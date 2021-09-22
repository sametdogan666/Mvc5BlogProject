using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;

namespace Mvc5BlogProject.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager _blogManager = new BlogManager();
        public PartialViewResult AuthorAbout(int id)
        {
            var authorDetail = _blogManager.GetBlogById(id);
            return PartialView(authorDetail);
        }

        public PartialViewResult AuthorPopularPost()
        {
            return PartialView();
        }
    }
}