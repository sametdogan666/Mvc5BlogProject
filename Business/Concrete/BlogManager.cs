using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BlogManager
    {
        Repository<Blog> blogRepository = new Repository<Blog>();

        public List<Blog> GetAll()
        {
            return blogRepository.List();
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

        public int BlogAddBM(Blog blog)
        {
            if (blog.BlogTitle == "" || blog.BlogImage == "" || blog.BlogTitle.Length <= 5 || blog.BlogContent.Length <= 200)
            {
                return -1;
            }

            return blogRepository.Insert(blog);
        }
    }
}
