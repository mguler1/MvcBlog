using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class AboutManager
    {
        Repository<About> Aboutrepo = new Repository<About>();
        public List<About> GetAll()
        {
            return Aboutrepo.List();
        }
        public void updateAbout(About a)
        {
            About about = Aboutrepo.Find(x => x.AboutId == a.AboutId);
            about.AboutContent = a.AboutContent;
            about.AboutContent2 = a.AboutContent2;
            about.AboutImage = a.AboutImage;
            about.AboutImage2 = a.AboutImage2;
            about.AboutId = a.AboutId;
            Aboutrepo.Update(about);
        }

    }
}
