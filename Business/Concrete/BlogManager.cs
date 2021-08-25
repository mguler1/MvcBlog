using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager
    {
        Repository<Blog> blogrepo = new Repository<Blog>();
        public List<Blog> GetAll()
        {
            return blogrepo.List();
        }
        public List<Blog> GetBlogById(int id)
        {
            return blogrepo.List(x => x.BlogId == id);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return blogrepo.List(x => x.AuthorId == id);
        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return blogrepo.List(x => x.CategoryId == id);
        }
        public int AddBlog(Blog b)
        {
            if (b.BlogTitle=="" ||b.BlogImage=="" ||b.BlogContent=="")
            {
                return -1;
            }
          return  blogrepo.Insert(b);
        }
        public int DeleteBlog(int z)
        {
          Blog blog= blogrepo.Find(x => x.BlogId == z);
            return blogrepo.Delete(blog);
        }
        public  Blog FindBlog(int getId)
        {
            return blogrepo.Find(x => x.BlogId == getId);
        }
        public int UpdateBlog(Blog p)
        {
            Blog blog = blogrepo.Find(x => x.BlogId == p.BlogId);
            blog.BlogTitle = p.BlogTitle;
            blog.BlogContent = p.BlogContent;
            blog.BlogContent = p.BlogContent;
            blog.BlogDate = p.BlogDate;
            blog.BlogImage = p.BlogImage;
            blog.CategoryId = p.CategoryId;
            blog.AuthorId = p.AuthorId;
            return blogrepo.Update(blog);
        }
    }
}
