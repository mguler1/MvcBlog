using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
 public   interface IRepository<T>
    {
        List<T> List();
        int Insert(T p);
        int Update(T p);
        int Delete(T p);
        T GetById(int id);
        List<T> List(Expression<Func<T, bool>> filter);//istenilen şarta göre search yapılmasını sağlar
        T Find(Expression<Func<T, bool>> where);
    }
}
