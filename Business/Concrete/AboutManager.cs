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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        Repository<About> Aboutrepo = new Repository<About>();
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }



        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _aboutDal.List();
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}