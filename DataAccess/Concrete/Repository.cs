﻿using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        public Repository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T p)
        {
            var deleteEntity = c.Entry(p);
            deleteEntity.State = EntityState.Deleted;
          c.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
             c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updateEntiy = c.Entry(p);
            updateEntiy.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
