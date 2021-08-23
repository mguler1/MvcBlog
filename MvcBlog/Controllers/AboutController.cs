using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager();
        public ActionResult Index()
        {
            var aboutcontent = abm.GetAll();
            return View(aboutcontent);
        }
        public PartialViewResult Footer()
        {
            var aboutContentlist=abm.GetAll();
            return PartialView(aboutContentlist);
        }
        public PartialViewResult MeetTheTeam()
        {
            return PartialView();
        }
       
    }
}