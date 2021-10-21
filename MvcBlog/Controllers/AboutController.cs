﻿using Business.Concrete;
using DataAccess.Ef;
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
            AuthorManager auth = new AuthorManager(new EfAuthorDal());
            var outhorlist = auth.GetList();
            return PartialView(outhorlist);
        }
        [HttpGet]
       public ActionResult UpdateAbout()
        {
            var aboutlsit = abm.GetAll(); 
            return View(aboutlsit);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About a)
        {
            abm.updateAbout(a);
            return RedirectToAction("UpdateAbout");
        }
    }
}