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

        public Author GetByID(int id)
        {
            return _authorDal.GetById(id);
        }

        public List<Author> GetList()
        {
            return _authorDal.List();
        }

        public void TAdd(Author t)
        {
            _authorDal.Insert(t);
        }

        public void TDelete(Author t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Author t)
        {
            _authorDal.Update(t);
        }
    }
}
