using DataAccess.Concrete;
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
        public void EditAuthor(Author p)
        {
            Author author = Authorrepo.Find(x => x.AuthorId == p.AuthorId);
            author.AboutShort = p.AboutShort;
            author.AuthorName = p.AuthorName;
            author.AuthorImage = p.AuthorImage;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorTitle = p.AuthorTitle;
            author.MailAdress = p.MailAdress;
            author.Password = p.Password;
            author.PhoneNumber = p.PhoneNumber;
            Authorrepo.Update(author);
        }
    }
}
