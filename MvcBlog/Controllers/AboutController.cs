using Business.Concrete;
using DataAccess.Ef;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
       
        // GET: About
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutcontent = abm.GetList();
            return View(aboutcontent);
        }
        public PartialViewResult Footer()
        {
            var aboutContentlist=abm.GetList();
            return PartialView(aboutContentlist);
        }
        public PartialViewResult MeetTheTeam()
        {
            AuthorManager auth = new AuthorManager(new EfAuthorDal());
            var outhorlist = auth.GetList();
            return PartialView(outhorlist);
        }
        [HttpGet]
       public ActionResult UpdateAbout()
        {
            var aboutlsit = abm.GetList(); 
            return View(aboutlsit);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About a)
        {
            abm.TUpdate(a);
            return RedirectToAction("UpdateAbout");
        }
    }
}