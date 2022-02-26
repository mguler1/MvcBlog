using BusinessLayer.Abstract;
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
    public class SubscribeMailManager : IMailService
    {

        IMailDal _maildal;

        public SubscribeMailManager(IMailDal maildal)
        {
            _maildal = maildal;
        }

        public SubScribe GetByID(int id)
        {
            return _maildal.GetById(id);
        }

        public List<SubScribe> GetList()
        {
            return _maildal.List();
        }

        public void TAdd(SubScribe t)
        {
            _maildal.Insert(t);
        }

        public void TDelete(SubScribe t)
        {
            _maildal.Delete(t);
        }

        public void TUpdate(SubScribe t)
        {
            _maildal.Update(t);
        }
    }
}