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
            throw new NotImplementedException();
        }

        public void Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
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

        public void DeleteBlogBM(int id)
        {
            Blog blog = blogRepository.Find(x => x.BlogId == id);
            blogRepository.Delete(blog);
        }

        public Blog FindBlog(int id)
        {
            return blogRepository.Find(x => x.BlogId == id);
        }

        public void UpdateBlog(Blog blog)
        {
            Blog _blog = blogRepository.Find(x => x.BlogId == blog.BlogId);
            _blog.BlogTitle = blog.BlogTitle;
            _blog.BlogContent = blog.BlogContent;
            _blog.BlogDate = blog.BlogDate;
            _blog.BlogImage = blog.BlogImage;
            _blog.CategoryId = blog.CategoryId;
            _blog.AuthorId = blog.AuthorId;

            blogRepository.Update(_blog);
        }
    }
}
