using Business.Concrete;
using Entity.Concrete;
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
        AuthorManager amn = new AuthorManager();

        [AllowAnonymous]
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail = bm.GetBlogById(id);
            return PartialView(authordetail);
        }
        [AllowAnonymous]
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorId = bm.GetAll().Where(x => x.BlogId == id).Select(y=>y.AuthorId).FirstOrDefault();
         
            var authorblogs = bm.GetBlogByAuthor(blogauthorId);
            return PartialView(authorblogs);
        }
        public ActionResult AuthorList()
        {
            var list = amn.GetAll();
            return View(list);
        }
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author a)
        {
            amn.AddAuthor(a);
            return RedirectToAction("AuthorList");
        }
        [HttpGet]
        public ActionResult UpdateAuthor(int id)
        {
            Author author = amn.FindAuthor(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult UpdateAuthor(Author a)
        {
            amn.UpdateAuthor(a);
            return RedirectToAction("AuthorList");
        }
    }
}