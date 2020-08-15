using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private DbContext Context;

        public DbSet<T> Something { get; set; }
        public Repository(DbContext context) 
        {
            Context = context;
            DbSet<T> something = Context.Set<T>();
            Something = something;
        }

        public T Add(T entity)
        {
            Something.Add(entity);
	        return entity;
        }

        public void Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
