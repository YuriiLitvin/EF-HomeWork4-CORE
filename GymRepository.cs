using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE
{
    public class GymRepository<T> : Repository<T>
    {
        public GymRepository(T entity) : base(entity) { }
        
    }
}
