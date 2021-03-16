using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BaseRepository<T> where T : Entity, new()
    {
        protected SqlDbContext context;
        protected DbSet<T> dbSet;
        public BaseRepository(SqlDbContext context1)
        {
            this.context = context1;
            dbSet = context1.Set<T>();
        }
        public T Find(int id)
        {
            return dbSet.Find(id);
        }
        public int Save(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public T LoadProxy(int id)
        {
            T entity = new T() { Id = id };
            dbSet.Attach(entity);
            return entity;
        }
    }
}
