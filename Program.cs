using EF_HomeWork_4_CORE.Entity;
using EF_HomeWork_4_CORE.Repository;
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
                    FullName = "Petrovich",
                    Email = "petrovich@gmail.com",
                    MobileNumber = "09923",
                    TypeOfTraining = TypeOfTraining.Dances
                };
                var coach2 = new Coach
                {
                    FullName = "Samson",
                    Email = "samson@gmail.com",
                    MobileNumber = "097325",
                    TypeOfTraining = TypeOfTraining.Fitness
                };
                var coach3 = new Coach
                {
                    FullName = "Oleksandr I",
                    Email = "sashkapower@gmail.com",
                    MobileNumber = "09544234",
                    TypeOfTraining = TypeOfTraining.PowerLifting
                };
                var coach4 = new Coach
                {
                    FullName = "Anna G.",
                    Email = "g_anna@gmail.com",
                    MobileNumber = "0930954",
                    TypeOfTraining = TypeOfTraining.Yoga
                };

                var CoachRepo = new CoachRepository(context);
                CoachRepo.Add(coach1);
                CoachRepo.Add(coach2);
                CoachRepo.Add(coach3);
                CoachRepo.Add(coach4);
                CoachRepo.Update(coach1);
                CoachRepo.Update(coach2);
                CoachRepo.Update(coach3);
                CoachRepo.Update(coach4);

                var gym1 = new Gym { Title = "Sparta", TrainingPeolpeCount = 100 };
                var gym2 = new Gym { Title = "FitnessLife", TrainingPeolpeCount = 150 };

                var GymRepo = new GymRepository(context);
                GymRepo.Add(gym1);
                GymRepo.Add(gym2);
                //var gymCollection = GymRepo.Get();

                //var gymToUpdate = gymCollection.FirstOrDefault(g => g.Id == 2);
                //gymToUpdate.TrainingPeolpeCount = 200;

                GymRepo.Update(gym1);
                GymRepo.Update(gym2);
                //GymRepo.Delete(1);

                var workout1 = new Workout 
                { 
                    TypeOfTraining = TypeOfTraining.Yoga,
                    CoachId = 1,
                    GymId = 1,
                    StartTime = new DateTime(2020, 08, 27, 09, 00, 00),
                    FinishTime = new DateTime(2020, 08, 27, 10, 00, 00)
                };
                var workout2 = new Workout
                {
                    TypeOfTraining = TypeOfTraining.Fitness,
                    CoachId = 1,
                    GymId = 2,
                    StartTime = new DateTime(2020, 08, 27, 10, 00, 00),
                    FinishTime = new DateTime(2020, 08, 27, 11, 00, 00)
                };
                var workout3 = new Workout
                {
                    TypeOfTraining = TypeOfTraining.PowerLifting,
                    CoachId = 2,
                    GymId = 1,
                    StartTime = new DateTime(2020, 08, 27, 11, 00, 00),
                    FinishTime = new DateTime(2020, 08, 27, 12, 00, 00)
                };
                var workout4 = new Workout
                {
                    TypeOfTraining = TypeOfTraining.Dances,
                    CoachId = 2,
                    GymId = 2,
                    StartTime = new DateTime(2020, 08, 27, 12, 00, 00),
                    FinishTime = new DateTime(2020, 08, 27, 13, 00, 00)
                };

                var workRepo = new WorkoutRepository(context);
                workRepo.Add(workout1);
                workRepo.Add(workout2);
                workRepo.Add(workout3);
                workRepo.Add(workout4);

                workRepo.Update(workout1);
                workRepo.Update(workout2);
                workRepo.Update(workout3);
                workRepo.Update(workout4);
            
            
            }
        }
    }
}
