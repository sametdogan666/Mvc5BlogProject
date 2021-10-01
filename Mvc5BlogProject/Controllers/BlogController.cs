using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using PagedList;
using PagedList.Mvc;

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

        public PartialViewResult BlogList(int page = 1)
        {
            var blogList = _blogManager.GetAll().OrderByDescending(x=>x.BlogDate).ToPagedList(page,6);
            return PartialView(blogList);
        }

        public PartialViewResult FeaturedPosts()
        {
            //1.Post
            var postTitle1 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogTitle)
                .FirstOrDefault();
            var postImage1 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogImage)
                .FirstOrDefault();
            var blogDate1 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogDate)
                .FirstOrDefault();
            var postCategory1 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.Category.CategoryName)
                .FirstOrDefault();
            ViewBag.postTitle1 = postTitle1;
            ViewBag.postImage1 = postImage1;
            ViewBag.blogDate1 = blogDate1;
            ViewBag.postCategory1 = postCategory1;

            //2.Post
            var postTitle2 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogTitle)
                .FirstOrDefault();
            var postImage2 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogImage)
                .FirstOrDefault();
            var blogDate2 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogDate)
                .FirstOrDefault();
            ViewBag.postTitle2 = postTitle2;
            ViewBag.postImage2 = postImage2;
            ViewBag.blogDate2 = blogDate2;

            //3.Post
            var postTitle3 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogTitle)
                .FirstOrDefault();
            var postImage3 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogImage)
                .FirstOrDefault();
            var blogDate3 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogDate)
                .FirstOrDefault();
            ViewBag.postTitle3 = postTitle3;
            ViewBag.postImage3 = postImage3;
            ViewBag.blogDate3 = blogDate3;

            //4.Post
            var postTitle4 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 6).Select(y => y.BlogTitle)
                .FirstOrDefault();
            var postImage4 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 6).Select(y => y.BlogImage)
                .FirstOrDefault();
            var blogDate4 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 6).Select(y => y.BlogDate)
                .FirstOrDefault();
            ViewBag.postTitle4 = postTitle4;
            ViewBag.postImage4 = postImage4;
            ViewBag.blogDate4 = blogDate4;

            //5.Post
            var postTitle5 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 5).Select(y => y.BlogTitle)
                .FirstOrDefault();
            var postImage5 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 5).Select(y => y.BlogImage)
                .FirstOrDefault();
            var blogDate5 = _blogManager.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 5).Select(y => y.BlogDate)
                .FirstOrDefault();
            ViewBag.postTitle5 = postTitle5;
            ViewBag.postImage5 = postImage5;
            ViewBag.blogDate5 = blogDate5;

            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }

        public ActionResult BlogDetails()
        {

            return View();
        }

        public PartialViewResult BlogCover(int id)
        {
            var blogDetailsList = _blogManager.GetBlogById(id);
            return PartialView(blogDetailsList);
        }

        public PartialViewResult BlogReadAll(int id)
        {
            var blogDetailsList = _blogManager.GetBlogById(id);
            return PartialView(blogDetailsList);
        }

        public ActionResult BlogByCategory(int id)
        {
            var blogListByCategorry = _blogManager.GetBlogByCategory(id);
            var categoryName = _blogManager.GetBlogByCategory(id).Select(y => y.Category.CategoryName).FirstOrDefault();
            var categoryDesc = _blogManager.GetBlogByCategory(id).Select(y => y.Category.CategoryDescription).FirstOrDefault();
            ViewBag.categoryName = categoryName;
            ViewBag.categoryDesc = categoryDesc;
            return View(blogListByCategorry);
        }

        public ActionResult AdminBlogList()
        {
            var blogList = _blogManager.GetAll();
            return View(blogList);
        }
        [HttpGet]
        public ActionResult AddNewBlog()
        {
           BlogContext blogContext = new BlogContext();
           List<SelectListItem> values = (from x in blogContext.Categories.ToList()
               select new SelectListItem()
               {
                   Text = x.CategoryName,
                   Value = x.CategoryId.ToString()
               }).ToList();
           ViewBag.values = values;
            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog blog)
        {
            return View();
        }
    }
}