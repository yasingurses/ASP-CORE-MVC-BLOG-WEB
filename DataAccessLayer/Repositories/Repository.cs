﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        public int Add(T p)
        {
            c.Add(p);
            return c.SaveChanges();
        }

        public int Delete(T p)
        {
            c.Remove(p);
            return c.SaveChanges();
        }

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public T getByID(int id)
        {
            return c.Set<T>().Find(id);
        }

        public int Update(T p)
        {
            c.Update(p);
            return c.SaveChanges();
        }
    }
}
