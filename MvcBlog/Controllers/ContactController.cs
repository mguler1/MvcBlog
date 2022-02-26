using Business.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Contact x)
        {
            cm.TAdd(x);
            return View();
        }
        public ActionResult SendBox()
        {
            var contactlist = cm.GetList();
            return View(contactlist);
        }
        public ActionResult MessageDetails(int id)
        {
            Contact contact = cm.GetByID(id);
            return View(contact);
        }
    }
}