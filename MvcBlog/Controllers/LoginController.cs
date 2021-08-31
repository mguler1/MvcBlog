using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcBlog.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorLogin(Author a)
        {
            Context c = new Context();
            var userinfo = c.Authors.FirstOrDefault(x => x.MailAdress == a.MailAdress && x.Password == a.Password);
            if (userinfo!=null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.MailAdress,false);
                Session["Mail"] = userinfo.MailAdress.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }
           
        }
    }
}