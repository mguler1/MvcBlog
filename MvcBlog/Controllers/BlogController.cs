using Business.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager bm = new BlogManager();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BlogList(int page=1)
        {
            var list = bm.GetAll().ToPagedList(page,3);
            return PartialView(list);
        }
        public PartialViewResult FeaturedPost()
        {
            //1.post
            var posttitle1 = bm.GetAll().OrderByDescending(z=>z.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage1 = bm.GetAll().OrderByDescending(z=>z.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogImage).FirstOrDefault();
            var postblogdate1 = bm.GetAll().OrderByDescending(z=>z.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogDate).FirstOrDefault();
            //2.post
            var posttitle2 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage2 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 2).Select(y => y.BlogImage).FirstOrDefault();
            var postblogdate2 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 2).Select(y => y.BlogDate).FirstOrDefault();
            //3.post
            var posttitle3 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage3 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogImage).FirstOrDefault();
            var postblogdate3 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogDate).FirstOrDefault();
            //4.post
            var posttitle4 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage4 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogImage).FirstOrDefault();
            var postblogdate4 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogDate).FirstOrDefault();

            //Öne çıkan post
            var posttitle5 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 5).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage5 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 5).Select(y => y.BlogImage).FirstOrDefault();
            var postblogdate5 = bm.GetAll().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 5).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle1 = posttitle1;
            ViewBag.postimage1 = postimage1;
            ViewBag.postblogdate1 = postblogdate1;

            ViewBag.posttitle2 = posttitle2;
            ViewBag.postimage2 = postimage2;
            ViewBag.postblogdate2 = postblogdate2;

            ViewBag.posttitle3 = posttitle3;
            ViewBag.postimage3 = postimage3;
            ViewBag.postblogdate3 = postblogdate3;

            ViewBag.posttitle4 = posttitle4;
            ViewBag.postimage4 = postimage4;
            ViewBag.postblogdate4 = postblogdate4;

            ViewBag.posttitle5 = posttitle5;
            ViewBag.postimage5 = postimage5;
            ViewBag.postblogdate5 = postblogdate5;


            return PartialView();
        }
        public PartialViewResult OtherFeaturedPost()
        {
            return PartialView();
        }

        public ActionResult BlogDetails()
        {
            return View();
        }
      public PartialViewResult BlogCover(int id)
        {
            var blogdetail = bm.GetBlogById(id);
            return PartialView(blogdetail);
        }
        public PartialViewResult BlogReadAll(int id)
        {
            var blogdetail = bm.GetBlogById(id);
            return PartialView(blogdetail);
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