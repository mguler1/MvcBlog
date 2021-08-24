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
        public int  BlContactAdd(Contact x)
        {
            if (x.Mail=="" || x.Message=="" ||x.Name=="" ||x.Subject=="" ||x.SurName=="" ||x.Mail.Length<=10 || x.Subject.Length<=3)
            {
                return -1;
            }
            return contact.Insert(x);
        }
    }
}
