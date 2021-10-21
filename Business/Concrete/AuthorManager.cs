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
    public class AuthorManager:IAuthorService
    {
        IAuthorDal _authorDal;
        Repository<Author> repo = new Repository<Author>();

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

      
       
      

        public List<Author> GetList()
        {
            return _authorDal.List();
        }

        public void AuthorAdd(Author author)
        {
            _authorDal.Insert(author);
        }

        public Author GetById(int id)
        {
            return _authorDal.GetById(id);
        }

        public void AuthorDelete(Author author)
        {
            throw new NotImplementedException();
        }

        public void AuthorUpdate(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
