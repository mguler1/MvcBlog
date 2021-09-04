﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IBlogService
    {
        List<Blog> GetList();
        void BlogAdd(Blog blog);
        Blog GetById(int id);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
    }
}
