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
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;
        Repository<Blog> blogRepository = new Repository<Blog>();

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetAll()
        {
            return _blogDal.List();
        }

        public void Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public void Delete(Blog blog)
        {
           _blogDal.Delete(blog);
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> GetBlogById(int id)
        {
            return blogRepository.List(x => x.BlogId == id);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return blogRepository.List(x => x.AuthorId == id);
        }

        public List<Blog> GetBlogByCategory(int id)
        {
            return blogRepository.List(x => x.CategoryId == id);
        }

        public void BlogAddBM(Blog blog)
        {
            //if (blog.BlogTitle == "" || blog.BlogImage == "" || blog.BlogTitle.Length <= 5 || blog.BlogContent.Length <= 200)
            //{
            //    return -1;
            //}

            blogRepository.Insert(blog);
        }
    }
}
