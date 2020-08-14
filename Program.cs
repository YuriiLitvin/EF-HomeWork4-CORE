using EF_HomeWork_4_CORE.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace EF_HomeWork_4_CORE
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new GymDbContext())
            {
                //var gym1 = context.Gyms.Add(new Gym { Title = "F1", TrainingPeolpeCount = 30 });
                //var gym2 = context.Gyms.Add(new Gym { Title = "SportLife", TrainingPeolpeCount = 150 });
                
                //var GymRepo = new GymRepository<DbContext>(context);
                //GymRepo.Add(gym1);
                //GymRepo.Add(gym2);
                context.Set
            
            }
            
            

        
        }
    }
}
