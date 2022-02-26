using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Ef;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
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
        BlogManager bm = new BlogManager(new EfBlogDal());
        CommentManager cm = new CommentManager(new EfCommentDal());

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult BlogList(int page = 1)
        {
            var list = bm.GetList().ToPagedList(page, 3);
            return PartialView(list);
        }
        [AllowAnonymous]
        public PartialViewResult FeaturedPost()
        {
            //1.post
            var posttitle1 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage1 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogImage).FirstOrDefault();
            var postblogdate1 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid1 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 1).Select(y => y.BlogId).FirstOrDefault();
            //2.post
            var posttitle2 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage2 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 2).Select(y => y.BlogImage).FirstOrDefault();
            var postblogdate2 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 2).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid2 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 2).Select(y => y.BlogId).FirstOrDefault();
            //3.post
            var posttitle3 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage3 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogImage).FirstOrDefault();
            var postblogdate3 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid3 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 3).Select(y => y.BlogId).FirstOrDefault();
            //4.post
            var posttitle4 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage4 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogImage).FirstOrDefault();
            var postblogdate4 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid4 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 4).Select(y => y.BlogId).FirstOrDefault();
            //Öne çıkan post
            var posttitle5 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 5).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage5 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 5).Select(y => y.BlogImage).FirstOrDefault();
            var postblogdate5 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 5).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid5 = bm.GetList().OrderByDescending(z => z.BlogId).Where(x => x.CategoryId == 5).Select(y => y.BlogId).FirstOrDefault();

            ViewBag.posttitle1 = posttitle1;
            ViewBag.postimage1 = postimage1;
            ViewBag.postblogdate1 = postblogdate1;
            ViewBag.blogpostid1 = blogpostid1;

            ViewBag.posttitle2 = posttitle2;
            ViewBag.postimage2 = postimage2;
            ViewBag.postblogdate2 = postblogdate2;
            ViewBag.blogpostid2 = blogpostid2;

            ViewBag.posttitle3 = posttitle3;
            ViewBag.postimage3 = postimage3;
            ViewBag.postblogdate3 = postblogdate3;
            ViewBag.blogpostid3 = blogpostid3;

            ViewBag.posttitle4 = posttitle4;
            ViewBag.postimage4 = postimage4;
            ViewBag.postblogdate4 = postblogdate4;
            ViewBag.blogpostid4 = blogpostid4;
            ViewBag.posttitle5 = posttitle5;
            ViewBag.postimage5 = postimage5;
            ViewBag.postblogdate5 = postblogdate5;
            ViewBag.blogpostid5 = blogpostid5;

            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult OtherFeaturedPost()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public ActionResult BlogDetails()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult BlogCover(int id)
        {
            var blogdetail = bm.GetBlogByID(id);
            return PartialView(blogdetail);
        }
        [AllowAnonymous]
        public PartialViewResult BlogReadAll(int id)
        {
            var blogdetail = bm.GetBlogByID(id);
            return PartialView(blogdetail);
        }
        public PartialViewResult CommentPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public ActionResult BlogByCategory(int id)
        {
            var bloglistbycatgeory = bm.GetBlogByCategory(id);
            var categoryname = bm.GetBlogByCategory(id).Select(y => y.Category.CategoryName).FirstOrDefault();
            var categorydesc = bm.GetBlogByCategory(id).Select(y => y.Category.CategoryDescription).FirstOrDefault();
            ViewBag.categoryname = categoryname;
            ViewBag.categorydesc = categorydesc;
            return View(bloglistbycatgeory);
        }
        public ActionResult AdminBlogList()
        {
            var bloglist = bm.GetList();
            return View(bloglist);
        }
        public ActionResult AdminBlogList2()
        {
            var bloglist = bm.GetList();
            return View(bloglist);
        }
        [Authorize(Roles = "A")]
        [HttpGet]
        public ActionResult AddNewBlog()
        {
            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList() select new SelectListItem { Text = x.CategoryName, Value = x.CategoryId.ToString() }).ToList();
            List<SelectListItem> values2 = (from x in c.Authors.ToList() select new SelectListItem { Text = x.AuthorName, Value = x.AuthorId.ToString() }).ToList();
            ViewBag.author = values2;
            ViewBag.category = values;
            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog b)
        {
            bm.TAdd(b);
            return RedirectToAction("AdminBlogList");
        }
        public ActionResult DeleteBlog(Blog id)
        {
            bm.TDelete(id);
            return RedirectToAction("AdminBlogList");
        }
        public ActionResult UpdateBlog(int id)
        {
            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList() select new SelectListItem { Text = x.CategoryName, Value = x.CategoryId.ToString() }).ToList();
            List<SelectListItem> values2 = (from x in c.Authors.ToList() select new SelectListItem { Text = x.AuthorName, Value = x.AuthorId.ToString() }).ToList();
            ViewBag.author = values2;
            ViewBag.category = values;
            Blog blog = bm.GetByID(id);
            return View(blog);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog p)
        {
            bm.TUpdate(p);
            return RedirectToAction("AdminBlogList");
        }
        public ActionResult GetCommentByBlog(int id)
        {
           
            var commentlist = cm.CommentByBlog(id);
            return View(commentlist);
        }
        public ActionResult AuthorBlogList(int id)
        {
            var blogs = bm.GetBlogByAuthor(id);
            return View(blogs);
        }
     
    }
}
