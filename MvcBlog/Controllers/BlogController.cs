﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BlogList()
        {
            return PartialView();
        }
        public PartialViewResult FeaturedPost()
        {
            return PartialView();
        }
        public PartialViewResult OtherFeaturedPost()
        {
            return PartialView();
        }
        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }
        public ActionResult BlogDetails()
        {
            return View();
        }
      public PartialViewResult BlogCover()
        {
            return PartialView();
        }
        public PartialViewResult BlogReadAll()
        {
            return PartialView();
        }
        public PartialViewResult CommentPartial()
        {
            return PartialView();
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}