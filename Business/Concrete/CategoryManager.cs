using Business.Abstract;
using DataAccess.Concrete;
using DataAccess.Interface;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        Repository<Category> repocategory = new Repository<Category>();
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void CategoryStatusFalseBL(int id)
        {
            Category category = _categoryDal.Find(x => x.CategoryId == id);
            //category.CategoryStatus = false;
            _categoryDal.Update(category);
        }
        public void CategoryStatusTrueBL(int id)
        {
            Category category = _categoryDal.Find(x => x.CategoryId == id);
            //category.CategoryStatus = true;
            _categoryDal.Update(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public Category GetByID(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}