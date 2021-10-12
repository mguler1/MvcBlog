using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SubScribeManager
    {
        Repository<SubScribe> repoSubscribe = new Repository<SubScribe>();
        public void BlAdd(SubScribe s)
        {
            //if (s.Mail.Length<=10 || s.Mail.Length>=50)
            //{
            //    return -1;
            //}
             repoSubscribe.Insert(s);
        }
    }
}
