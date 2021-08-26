using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repo = new Repository<Author>();
    public List<Author> GetAll()
    {
        return repo.List();
    }
        public int AddAuthor(Author A)
        {
            return repo.Insert(A);
        }
        public Author FindAuthor(int getId)
        {
            return repo.Find(x => x.AuthorId == getId);
        }
        public int UpdateAuthor(Author p)
        {
            Author author = repo.Find(x => x.AuthorId == p.AuthorId);
            author.AuthorName = p.AuthorName;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorImage = p.AuthorImage;
            author.AuthorId = p.AuthorId;
            return repo.Update(author);
        }
    }
}
