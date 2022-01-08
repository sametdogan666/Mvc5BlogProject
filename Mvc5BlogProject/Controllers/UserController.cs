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

        public ActionResult Index(string p)
        {
            p = "cemilekose@gmail.com";
            var profileValues = userProfile.GetAuthorByMail(p);
            return View(profileValues);
        }
    }
}