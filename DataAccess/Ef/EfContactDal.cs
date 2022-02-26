using DataAccess.Concrete;
using DataAccess.Interface;

using Entity.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactDal : Repository<Contact>, IContactDal
    {
    }
}
