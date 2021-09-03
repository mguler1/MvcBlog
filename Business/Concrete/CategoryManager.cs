using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        Repository<Category> repocategory = new Repository<Category>();
        public List<Category> GetAll()
        {
            return repocategory.List();
        }
        public int CategoryAdd(Category c)
        {
            return repocategory.Insert(c);
        }
        public Category FindCategory(int getId)
        {
            return repocategory.Find(x => x.CategoryId == getId);
        }
        public int EditCategory(Category p)
        {
            Category category = repocategory.Find(x => x.CategoryId == p.CategoryId);
            category.CategoryName = p.CategoryName;
            category.CategoryId = p.CategoryId;
            category.CategoryDescription = p.CategoryDescription;
            
            return repocategory.Update(category);
        }
    }
}
