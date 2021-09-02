using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            var categories = cm.GetAll();
            return View(categories);
        }
        [AllowAnonymous]
        public PartialViewResult CategoryList()
        {
            var categories = cm.GetAll();
            return PartialView(categories);
        }
        public ActionResult AdminCategoryList()
        {
            var categories = cm.GetAll();
            return View(categories);
        }
    }
}