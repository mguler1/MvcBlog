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
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
    
    [HttpPost]
    public ActionResult AdminLogin(Admin b)
    {
        Context c = new Context();
        var admininfo = c.Admins.FirstOrDefault(x => x.UserName == b.UserName && x.Password == b.Password);
        if (admininfo != null)
        {
            FormsAuthentication.SetAuthCookie(admininfo.UserName, false);
            Session["UserName"] = admininfo.UserName.ToString();
            return RedirectToAction("AdminBlogList", "Blog");
        }
        else
        {
            return RedirectToAction("AdminLogin", "Login");
        }

    }
}
}