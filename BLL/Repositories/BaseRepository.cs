﻿using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BaseRepository<T> where T : Entity
    {
        protected SqlDbContext Context;
        protected DbSet<T> dbSet;
        public BaseRepository(SqlDbContext context)
        {
            this.Context = context;
            dbSet = context.Set<T>();
        }
        public T Find(int id)
        {
            return dbSet.Find(id);
        }
        public int Save(T entity)
        {
            dbSet.Add(entity);
            Context.SaveChanges();
            return entity.Id;
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            Context.SaveChanges();

        }
    }
}
