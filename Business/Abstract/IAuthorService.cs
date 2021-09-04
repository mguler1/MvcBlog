﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IAuthorService
    {
        List<Author> GetList();
        void AuthorAdd(Author author);
        Author GetById(int id);
        void AuthorDelete(Author author);
        void AuthorUpdate(Author author);
    }
}
