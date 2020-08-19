using EF_HomeWork_4_CORE.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF_HomeWork_4_CORE
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FitnessDbContext())
            {
                var gym1 = new Gym { Title = "F1", TrainingPeolpeCount = 30 };
                var gym2 = new Gym { Title = "SportLife", TrainingPeolpeCount = 150 };

                var GymRepo = new GymRepository(context);
                //GymRepo.Add(gym1);
                //GymRepo.Add(gym2);
                var gymCollection = GymRepo.Get();

                var gymToUpdate = gymCollection.FirstOrDefault(g => g.Id == 2);
                gymToUpdate.TrainingPeolpeCount = 200;
                
                GymRepo.Update(gymToUpdate);
                //GymRepo.Delete(1);
            
                
            }
        }
    }
}
