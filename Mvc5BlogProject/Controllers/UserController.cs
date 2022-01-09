﻿using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Mvc5BlogProject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserProfileManager userProfile = new UserProfileManager();
        BlogManager _blogManager = new BlogManager();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1(string p)
        {
            p = (string)Session["Mail"];
            var profileValues = userProfile.GetAuthorByMail(p);
            return PartialView(profileValues);
        }

        public ActionResult BlogList(string p)
        {
            p = (string)Session["Mail"];
            BlogContext blogContext = new BlogContext();
            int id = blogContext.Authors.Where(x => x.AuthorGmail == p).Select(y => y.AuthorId).FirstOrDefault();
            var blogs = userProfile.GetBlogByAuthor(id);
            return View(blogs);
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Blog blog = _blogManager.FindBlog(id);
            BlogContext blogContext = new BlogContext();
            List<SelectListItem> values = (from x in blogContext.Categories.ToList()
                select new SelectListItem()
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.values = values;

            List<SelectListItem> values2 = (from x in blogContext.Authors.ToList()
                select new SelectListItem()
                {
                    Text = x.AuthorName,
                    Value = x.AuthorId.ToString()
                }).ToList();
            ViewBag.values2 = values2;
            return View(blog);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            _blogManager.UpdateBlog(blog);
            return RedirectToAction("BlogList");
        }
    }
}