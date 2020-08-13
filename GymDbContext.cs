﻿using EF_HomeWork_4_CORE.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE
{
    public class GymDbContext : DbContext
    {
        public DbSet<Coach> Coaches { get; set; }

        public DbSet<Gym> Gyms { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            var connectingString = @"Data Source=(localdb)\MSSSQLLocalDB; Initial Catalog=GymDb; Integrated Security=True";
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
                    .Property(p => p.FullName)
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

        }
    }
}
