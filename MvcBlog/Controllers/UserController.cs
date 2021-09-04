using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcBlog.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserProfileManager um = new UserProfileManager();
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialProfile(string p)
        {
             p = (string)Session["MailAdress"];
            var profilvalue = um.GetAuthorByMail(p);
            return PartialView(profilvalue);
        }
        public ActionResult BlogList(int id=0)
        {
           string p = (string)Session["MailAdress"];
           
             id = c.Authors.Where(x => x.MailAdress == p).Select(y => y.AuthorId).FirstOrDefault(); 
            var blogs = um.GetBlogByAuthor(id);
            return View(blogs);
        }
            public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("AdminLogin", "Login");
        }
    }
}