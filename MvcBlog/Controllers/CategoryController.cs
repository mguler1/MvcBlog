using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Ef;
using DataAccess.Interface;
using Entity.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class CategoryController : Controller
    {
       CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categories = cm.GetList();
            return View(categories);
        }
        [AllowAnonymous]
        public PartialViewResult CategoryList()
        {
            var categories = cm.GetList();
            return PartialView(categories);
        }
        public ActionResult AdminCategoryList()
        {
            var categories = cm.GetList();
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
            CategoryValidator categoryvalidator = new CategoryValidator();
            ValidationResult result = categoryvalidator.Validate(ca);
            if (result.IsValid)
            {
                cm.TAdd(ca);
                return RedirectToAction("AdminCategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            Category category = cm.GetByID(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category a)
        {
            cm.TUpdate(a);
            return RedirectToAction("AdminCategoryList");
        }
        public ActionResult DeleteCategory(int  id)
        {
            cm.CategoryStatusFalseBL(id);
            return RedirectToAction("AdminCategoryList");
        }
        public ActionResult CategoryStatusTrue(int id)
        {
            cm.CategoryStatusTrueBL(id);
            return RedirectToAction("AdminCategoryList");
        }
    }
}