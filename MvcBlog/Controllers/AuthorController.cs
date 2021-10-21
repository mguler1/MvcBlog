using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Ef;
using Entity.Concrete;
using FluentValidation.Results;
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
        AuthorManager amn = new AuthorManager(new EfAuthorDal());

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
            var list = amn.GetList();
            return View(list);
        }
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author a)
        {
            AuthorValidator authorvalidator = new AuthorValidator();
            ValidationResult result = authorvalidator.Validate(a);
            if (result.IsValid)
            {
                amn.AuthorAdd(a);
                return RedirectToAction("AuthorList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult UpdateAuthor(int id)
        {
            Author author = amn.GetById(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult UpdateAuthor(Author a)
        {
            AuthorValidator authorvalidator = new AuthorValidator();
            ValidationResult result = authorvalidator.Validate(a);
            if (result.IsValid)
            {
                amn.AuthorUpdate(a);
                return RedirectToAction("AuthorList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }
    }
}