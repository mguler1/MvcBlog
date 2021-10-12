using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
  public  class ContactManager
    {
        Repository<Contact> contact = new Repository<Contact>();
        public void  BlContactAdd(Contact x)
        {
            //if (x.Mail=="" || x.Message=="" ||x.Name=="" ||x.Subject=="" ||x.SurName=="" ||x.Mail.Length<=10 || x.Subject.Length<=3)
            //{
            //    return -1;
            //}
             contact.Insert(x);
        }
        public List <Contact> GetAll()
        {
            return contact.List();
        }
        public Contact MessageDetail(int id)
        {
            return contact.Find(x => x.ContactId == id);
        }
    }
}
