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
  public  class ContactManager:IContactService
    {
        IContactDal _contactdal;
        Repository<Contact> contact = new Repository<Contact>();
        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }
        public Contact GetByID(int id)
        {
            return _contactdal.Find(x => x.ContactId == id);
        }

        public List<Contact> GetList()
        {
            return _contactdal.List();
        }

        public void TAdd(Contact t)
        {
            _contactdal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }

    }
}
