using EF_HomeWork_4_CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE.EntityConfiguration
{
    public class CoachConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.Property(p => p.FullName).HasMaxLength(255);

            builder.Property(p => p.MobileNumber).HasMaxLength(255);

            builder.Property(p => p.Email).HasMaxLength(255);

            builder.Property(p => p.TypeOfTraining).HasConversion<int>();

            builder.Property(p => p.FullName).IsRequired();

            builder.Property(p => p.Email).IsRequired();

            builder.Property(p => p.MobileNumber).IsRequired();
        }
    }
}
