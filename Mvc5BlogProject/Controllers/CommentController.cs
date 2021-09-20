using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using Entities.Concrete;

namespace Mvc5BlogProject.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager commentManager = new CommentManager();
        public PartialViewResult CommentList(int id)
        {
            var commentList = commentManager.CommentByBlog(id);
            return PartialView(commentList);
        }

        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult LeaveComment(Comment comment)
        {
            commentManager.CommentAdd(comment);
            return PartialView();
        }
    }
}