using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using Entities.Concrete;

namespace Mvc5BlogProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager _contactManager = new ContactManager();

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult SendMessage(Contact contact)
        {
            _contactManager.Add(contact);
            return View();
        }

        public ActionResult SendBox()
        {
            var messageList = _contactManager.GetAll();
            return View(messageList);
        }
        public ActionResult MessageDetails(int id)
        {
            Contact contact = _contactManager.GetContactDetails(id);
            return View();
        }
    }
}