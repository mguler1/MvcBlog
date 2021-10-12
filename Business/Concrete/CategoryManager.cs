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
    public class CategoryManager:ICategoryService
    {
        Repository<Category> repocategory = new Repository<Category>();
       ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void EditCategory(Category p)
        {
             repocategory.Update(p);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }
    }
}
