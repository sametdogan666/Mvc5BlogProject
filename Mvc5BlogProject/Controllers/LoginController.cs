using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mvc5BlogProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorLogin(Author author)
        {
            BlogContext blogContext = new BlogContext();
            var userInfo = blogContext.Authors.FirstOrDefault(x => x.AuthorGmail == author.AuthorGmail && x.Password == author.Password);
            if (userInfo != null)
            {
                FormsAuthentication.SetAuthCookie(userInfo.AuthorGmail, false);
                Session["Mail"] = userInfo.AuthorGmail.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }
          
        }

        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            BlogContext blogContext = new BlogContext();
            var admınInfo = blogContext.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if (admınInfo != null)
            {
                FormsAuthentication.SetAuthCookie(admınInfo.UserName, false);
                Session["UserName"] = admınInfo.UserName.ToString();
                return RedirectToAction("AdminBlogList", "Blog");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }

        }
    }
}