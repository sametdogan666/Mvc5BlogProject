﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities.Concrete;

namespace Mvc5BlogProject.Controllers
{
    public class SubscribeMailController : Controller
    {
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail subscribeMail)
        {
            return PartialView();
        }
    }
}