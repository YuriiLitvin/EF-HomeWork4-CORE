using EF_HomeWork_4_CORE.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE
{
    public class FitnessDbContext : DbContext
    {
        public  DbSet<Coach> Coaches { get; set; }

        public DbSet<Gym> Gyms { get; set; }

        public DbSet<Workout> Workouts { get; set; }
        
        public FitnessDbContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            var connectingString = @"Data Source=(localdb)\ProjectsV13; 
                                     Initial Catalog=FitnessDb; 
                                     Integrated Security=True";
            
            optionsBuilder.UseSqlServer(connectingString);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coach>()
                .Property(p => p.FullName)
                .HasMaxLength(255);
            
            modelBuilder.Entity<Coach>()
                    .Property(p => p.MobileNumber)
                    .HasMaxLength(255);
            
            modelBuilder.Entity<Coach>()
                .Property(p => p.Email)
                .HasMaxLength(255);

            modelBuilder.Entity<Coach>()
                    .Property(p => p.Trainings)
                    .HasConversion<int>();

            modelBuilder.Entity<Coach>()
                    .Property(p => p.FullName)
                    .IsRequired();

            modelBuilder.Entity<Coach>()
                   .Property(p => p.Email)
                   .IsRequired(); 

            modelBuilder.Entity<Coach>()
                    .Property(p => p.MobileNumber)
                    .IsRequired();

            

            modelBuilder.Entity<Gym>()
                    .Property(g => g.Title)
                    .HasMaxLength(255);

            modelBuilder.Entity<Gym>()
                    .Property(g => g.Title)
                    .IsRequired();
            
            modelBuilder.Entity<Gym>()
                   .Property(g => g.TrainingPeolpeCount)
                   .IsRequired();



            modelBuilder.Entity<Workout>()
                    .Property(w => w.Trainings)
                    .HasConversion<int>();
            
            modelBuilder.Entity<Workout>()
                   .Property(w => w.Trainings)
                   .IsRequired();

            modelBuilder.Entity<Workout>()
                       .Property(w => w.Coach)
                       .IsRequired();
            
            modelBuilder.Entity<Workout>()
                   .Property(w => w.Gym)
                   .IsRequired();

            modelBuilder.Entity<Workout>()
                   .Property(w => w.StartTime)
                   .IsRequired();
            
            modelBuilder.Entity<Workout>()
                       .Property(w => w.FinishTime)
                       .IsRequired();
        }
    }
}
