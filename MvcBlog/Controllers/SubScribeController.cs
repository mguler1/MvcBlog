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
    public class SubScribeController : Controller
    {
        SubscribeMailManager sm = new SubscribeMailManager(new EfMailDal());
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
     
        public PartialViewResult AddMail(SubScribe x)
        {
            sm.TAdd(x);
            return PartialView();
        }
    }
}