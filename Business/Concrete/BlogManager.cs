﻿using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager
    {
        Repository<Blog> blogrepo = new Repository<Blog>();
        public List<Blog> GetAll()
        {
            return blogrepo.List();
        }
        public List<Blog> GetBlogById(int id)
        {
            return blogrepo.List(x => x.BlogId == id);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return blogrepo.List(x => x.AuthorId == id);
        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return blogrepo.List(x => x.CategoryId == id);
        }
    }
}