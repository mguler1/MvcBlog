using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repo = new Repository<Author>();
    public List<Author> GetAll()
    {
        return repo.List();
    }
}
}
