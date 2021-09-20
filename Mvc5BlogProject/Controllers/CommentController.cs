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
       
        public PartialViewResult CommentList(int id)
        {
            CommentManager commentManager = new CommentManager();
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
            CommentManager commentManager = new CommentManager();
            commentManager.CommentAdd(comment);
            return PartialView();
        }
    }
}