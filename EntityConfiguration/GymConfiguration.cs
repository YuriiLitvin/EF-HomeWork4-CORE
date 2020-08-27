using EF_HomeWork_4_CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE.EntityConfiguration
{
    public class GymConfiguration : IEntityTypeConfiguration<Gym>
    {
        public void Configure(EntityTypeBuilder<Gym> builder)
        {
            builder.Property(g => g.Title).HasMaxLength(255);

            builder.Property(g => g.Title).IsRequired();

            builder.Property(g => g.TrainingPeolpeCount).IsRequired();
        }
    }
}
