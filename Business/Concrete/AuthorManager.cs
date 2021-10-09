using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repositoryAuthor = new Repository<Author>();

        //Tum Yazar Listesini Getirme
        public List<Author> GetAll()
        {
            return repositoryAuthor.List();
        }

        //Yeni Yazar Ekleme Islemi
        public int Add(Author author)
        {
            //Parametreden Gonderilen Degerlerin Gecerliliginin Kontrolu
            if (author.AuthorName == "" || author.AboutShort == "" || author.AuthorTitle == "")
            {
                return -1;
            }

            return repositoryAuthor.Insert(author);
        }

        //Yazari id degerine gore edit sayfasina tasima
        public Author FindAuthor(int id)
        {
            return repositoryAuthor.Find(x => x.AuthorId == id);
        }
    }
}
