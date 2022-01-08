using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5BlogProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult AuthorLogin()
        {
            return View();
        }
    }
}