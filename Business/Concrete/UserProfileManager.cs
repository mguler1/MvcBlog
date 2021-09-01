﻿using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
  public  class UserProfileManager
    {
        Repository<Author> Authorrepo = new Repository<Author>();
        Repository<Blog> Blogrepo = new Repository<Blog>();
        public List<Author> GetAuthorByMail(string p)
        {
            return Authorrepo.List(x => x.MailAdress == p);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return Blogrepo.List(x => x.AuthorId == id);
        }
    }
}
