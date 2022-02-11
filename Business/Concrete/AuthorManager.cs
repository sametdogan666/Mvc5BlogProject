using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;
        Repository<Author> repositoryAuthor = new Repository<Author>();

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        //Tum Yazar Listesini Getirme
        public List<Author> GetAll()
        {
            return _authorDal.List();
        }

        //Yeni Yazar Ekleme Islemi
        public void Add(Author author)
        {
            _authorDal.Insert(author);
        }

        public Author GetById(int id)
        {
            return _authorDal.GetById(id);
        }

        public void Delete(Author author)
        {
            throw new NotImplementedException();
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }

    }
}
