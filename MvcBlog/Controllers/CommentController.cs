﻿using Business.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager cm = new CommentManager();
        public PartialViewResult CommentList(int id)
        {
            var commentlist = cm.CommentByBlog(id);
            return PartialView(commentlist);
        }
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LeaveComment(Comment c)
        {
            cm.CommentAdd(c);
            return PartialView();
        }
        public ActionResult AdminCommentList()
        {
            var commentlist = cm.CommentByStatus();
            return View(commentlist);
        }
        public ActionResult AdminCommentListFalse()
        {
            var commentlist = cm.CommentByStatusFalse();
            return View(commentlist);
        }

        public ActionResult UpdateCommentToFalse(int id )
        {
            cm.UpdateCommentStatusToFalse(id);
            return RedirectToAction("AdminCommentList");
        }
        public ActionResult UpdateCommentToTrue(int id)
        {
            cm.CommentStatusChangeTrue(id);
            return RedirectToAction("AdminCommentList");
        }
    }
}