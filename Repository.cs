using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_HomeWork_4_CORE
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private DbContext Context;

        private DbSet<T> DbSet { get; set; }
        public Repository(DbContext context) 
        {
            Context = context;
            DbSet<T> dbSet = Context.Set<T>();
            DbSet = dbSet;
        }

        public T Add(T entity)
        {
            DbSet.Add(entity);
	        return entity;
        }

        public void Delete(int entityId)
        {
            var unit = DbSet.FirstOrDefault(u => u.Id == entityId);
            DbSet.Remove(unit);
        }

        public IEnumerable<T> Get()
        {
            var collection = DbSet.ToList();
            return collection;
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
