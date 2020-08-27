using EF_HomeWork_4_CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE.EntityConfiguration
{
    public class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {

            builder.Property(w => w.TypeOfTraining).HasConversion<int>();


            builder.Property(w => w.CoachId).IsRequired();

            builder.Property(w => w.GymId).IsRequired();

            builder.Property(w => w.TypeOfTraining).IsRequired();

            builder.Property(w => w.StartTime).IsRequired();

            builder.Property(w => w.FinishTime).IsRequired();

            builder.HasOne(p => p.Coach);
            
            builder.HasOne(p => p.Gym);

        }
    }
}
