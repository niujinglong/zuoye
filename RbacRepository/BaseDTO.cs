﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEF;
using RbacRepository.FenYe;

namespace RbacRepository
{
    public abstract class BaseDTO<T, TKey> : IBaseDTO<T, TKey>
        where T : class
        where TKey : struct
    {
        protected MyDbContext db;
        public virtual int Add(T list)
        {
            db.Set<T>().Add(list);
            return db.SaveChanges();
        }

        public virtual int Del(TKey k)
        {
            var list = db.Set<T>().Find(k);
            db.Remove(list);
            return db.SaveChanges();
        }

        public virtual T Get(int id)
        {
            return db.Set<T>().Find(id);
        }

        public virtual List<T> GetAll()
        {
            var list = db.Set<T>().AsQueryable();
            return list.ToList();
        }

        public virtual shuju<T> GetFen(TiaoJian j)
        {
            var list = GetAll();
            var to = list.Count();
            var data = list.Skip((j.pageindex - 1) * j.pagesize).Take(j.pagesize);
            shuju<T> s = new shuju<T>();
            s.totacount = to;
            s.shu = data.ToList();
            return s;
        }

        public virtual int Upd(T t)
        {
            db.Entry<T>(t).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}