using EF_HomeWork_4_CORE.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;

namespace EF_HomeWork_4_CORE
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FitnessDbContext())
            {
                var coach1 = new Coach
                {
                    FullName = "Petrov",
                    Email = "petrov@gmail.com",
                    MobileNumber = "09923",
                    TypeOfTraining = 0
                };

                var CoachRepo = new CoachRepository(context);
                CoachRepo.Add(coach1);
                CoachRepo.Update(coach1);
                
                //var gym1 = new Gym { Title = "Sparta", TrainingPeolpeCount = 100 };
                //var gym2 = new Gym { Title = "FitnessLife", TrainingPeolpeCount = 150 };

                //var GymRepo = new GymRepository(context);
                //GymRepo.Add(gym1);
                //GymRepo.Add(gym2);
                ////var gymCollection = GymRepo.Get();

                ////var gymToUpdate = gymCollection.FirstOrDefault(g => g.Id == 2);
                ////gymToUpdate.TrainingPeolpeCount = 200;

                //GymRepo.Update(gym1);
                //GymRepo.Update(gym2);
                ////GymRepo.Delete(1);
            }
        }
    }
}
