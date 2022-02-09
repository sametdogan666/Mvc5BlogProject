using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        void Add(Comment comment);
        Comment GetById(int id);
        void Delete(Comment comment);
        void Update(Comment comment);
    }
}
