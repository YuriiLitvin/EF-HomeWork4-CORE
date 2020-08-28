using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_HomeWork_4_CORE
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {

        private DbSet<T> DbSet { get; set; }
        public Repository(DbContext context) 
        {
            DbSet<T> dbSet = context.Set<T>();
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
            return DbSet;
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
        }
    }
}
