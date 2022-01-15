using Business.Abstract;
using DataAccess.Concrete;
using DataAccess.Interface;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager:IBlogService
    {
        IBlogDal _blogdal;


        Repository<Blog> blogrepo = new Repository<Blog>();

        public BlogManager(IBlogDal blogdal)
        {
            _blogdal = blogdal;
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
      
   
   
      

        public List<Blog> GetList()
        {
           return  _blogdal.List();
        }

        public void BlogAdd(Blog blog)
        {
            _blogdal.Insert(blog);
        }

        public Blog GetById(int id)
        {
            return _blogdal.GetById(id);
        }

        public void BlogDelete(Blog blog)
        {
            _blogdal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogdal.Update(blog);
        }
    }
}
