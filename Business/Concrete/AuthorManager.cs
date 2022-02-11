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
            throw new NotImplementedException();
        }

        public void Delete(Author author)
        {
            throw new NotImplementedException();
        }

        public void Update(Author author)
        {
            throw new NotImplementedException();
        }

        //Yazari id degerine gore edit sayfasina tasima
        public Author FindAuthor(int id)
        {
            return repositoryAuthor.Find(x => x.AuthorId == id);
        }

        public void EditAuthor(Author author)
        {
            Author _author = repositoryAuthor.Find(x => x.AuthorId == author.AuthorId);
            _author.AboutShort = author.AboutShort;
            _author.AuthorName = author.AuthorName;
            _author.AuthorImage = author.AuthorImage;
            _author.AuthorAbout = author.AuthorAbout;
            _author.AuthorTitle = author.AuthorTitle;
            _author.AuthorGmail = author.AuthorGmail;
            _author.AuthorTwitter = author.AuthorTwitter;
            _author.AuthorInstagram = author.AuthorInstagram;
            _author.Password = author.Password;
            _author.PhoneNumber = author.PhoneNumber;
            repositoryAuthor.Update(_author);
        }
    }
}
