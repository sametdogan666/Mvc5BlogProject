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
        [AllowAnonymous]
        public PartialViewResult CommentList(int id)
        {
            CommentManager commentManager = new CommentManager();
            var commentList = commentManager.CommentByBlog(id);
            return PartialView(commentList);
        }
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [AllowAnonymous]
        [HttpPost]
        public PartialViewResult LeaveComment(Comment comment)
        {
            CommentManager commentManager = new CommentManager();
            comment.CommentStatus = true;
            commentManager.CommentAdd(comment);
            return PartialView();
        }

        public ActionResult AdminCommentListTrue()
        {
            CommentManager commentManager = new CommentManager();
            var commentList = commentManager.CommentByStatusTrue();
            return View(commentList);
        }

        public ActionResult AdminCommentListFalse()
        {
            CommentManager commentManager = new CommentManager();
            var commentList = commentManager.CommentByStatusFalse();
            return View(commentList);
        }

        public ActionResult StatusChangeToFalse(int id)
        {
            CommentManager commentManager = new CommentManager();
            commentManager.CommentStatusChangeToFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }

        public ActionResult StatusChangeToTrue(int id)
        {
            CommentManager commentManager = new CommentManager();
            commentManager.CommentStatusChangeToTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }
    }
}