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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;


        Repository<Blog> blogrepo = new Repository<Blog>();

        public BlogManager(IBlogDal blogdal)
        {
            _blogDal = blogdal;
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.List(x => x.BlogId == id);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return _blogDal.List(x => x.AuthorId == id);
        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return _blogDal.List(x => x.CategoryId == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.List();
        }

        public Blog GetByID(int id)
        {
            return _blogDal.GetById(id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }


    }
}