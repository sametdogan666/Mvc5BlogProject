using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetAll();
        void Add(Author author);
        Author GetById(int id);
        void Delete(Author author);
        void Update(Author author);
    }
}
