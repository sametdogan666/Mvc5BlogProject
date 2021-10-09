using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using Entities.Concrete;

namespace Mvc5BlogProject.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager _blogManager = new BlogManager();
        AuthorManager _authorManager = new AuthorManager();
        public PartialViewResult AuthorAbout(int id)
        {
            var authorDetail = _blogManager.GetBlogById(id);
            return PartialView(authorDetail);
        }

        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogAuthorId = _blogManager.GetAll().Where(x => x.BlogId == id).Select(y => y.AuthorId)
                .FirstOrDefault();
            var authorBlogs = _blogManager.GetBlogByAuthor(blogAuthorId);
            return PartialView(authorBlogs);
        }

        public ActionResult AuthorList()
        {
            var results = _authorManager.GetAll();
            return View(results);
        }
        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author author)
        {
            _authorManager.Add(author);
            return RedirectToAction("AuthorList");
        }
        [HttpGet]
        public ActionResult AuthorEdit(int id)
        {
            Author author = _authorManager.FindAuthor(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult AuthorEdit(Author author)
        {
            return View();
        }
    }
}