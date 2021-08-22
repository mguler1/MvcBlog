using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager bm = new BlogManager();
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail = bm.GetBlogById(id);
            return PartialView(authordetail);
        }
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorId = bm.GetAll().Where(x => x.BlogId == id).Select(y=>y.AuthorId).FirstOrDefault();
         
            var authorblogs = bm.GetBlogByAuthor(blogauthorId);
            return PartialView(authorblogs);
        }
    }
}