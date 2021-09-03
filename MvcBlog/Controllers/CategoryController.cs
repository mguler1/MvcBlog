using Business.Concrete;
using Entity.Concrete;
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
        [HttpGet]
        public ActionResult AdminCategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminCategoryAdd(Category ca)
        {
            cm.CategoryAdd(ca);
            return RedirectToAction("AdminCategoryList");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            Category category = cm.FindCategory(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category a)
        {
            cm.EditCategory(a);
            return RedirectToAction("AdminCategoryList");
        }
    }
}