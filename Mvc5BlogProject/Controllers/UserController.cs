using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5BlogProject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserProfileManager userProfile = new UserProfileManager();

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
    }
}