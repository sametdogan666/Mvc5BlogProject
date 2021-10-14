using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CommentManager
    {
        Repository<Comment> commentRepository = new Repository<Comment>();

        public List<Comment> CommentList()
        {
            return commentRepository.List();
        }

        public List<Comment> CommentByBlog(int id)
        {
            return commentRepository.List(x => x.BlogId == id);
        }

        public List<Comment> CommentByStatusTrue()
        {
            return commentRepository.List(x => x.CommentStatus == true);
        }

        public int CommentAdd(Comment comment)
        {
            if (comment.CommentText.Length <= 3 || comment.CommentText.Length >= 300 || comment.UserName == "" || comment.Email == "" || comment.UserName.Length <= 3)
            {
                return -1;
            }

            return commentRepository.Insert(comment);
        }

        public int CommentStatusChangeToFalse(int id)
        {
            Comment comment = commentRepository.Find(x => x.CommentId == id);
            comment.CommentStatus = false;
            return commentRepository.Update(comment);
        }
    }
}
