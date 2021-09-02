using Business.Concrete;
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
        [AllowAnonymous]
        // GET: SubScribe
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
     
        public PartialViewResult AddMail(SubScribe x)
        {
            SubScribeManager sm = new SubScribeManager();
            sm.BlAdd(x);
            return PartialView();
        }
    }
}