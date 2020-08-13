using System;

namespace EF_HomeWork_4_CORE
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new GymDbContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
