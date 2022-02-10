using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repoUser = new Repository<Author>();
        Repository<Blog> repoUserBlog = new Repository<Blog>();

        public List<Author> GetAuthorByMail(string p)
        {
            return repoUser.List(x => x.AuthorGmail == p);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoUserBlog.List(x => x.AuthorId == id);
        }

        public void EditAuthor(Author author)
        {
            Author _author = repoUser.Find(x => x.AuthorId == author.AuthorId);
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
            repoUser.Update(_author);
        }
    }
}
