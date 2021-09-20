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
    }
}
