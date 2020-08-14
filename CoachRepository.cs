using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE
{
    public class CoachRepository<T> : Repository<T>
    {
        public CoachRepository(T entity) : base(entity) { }
    }
}
