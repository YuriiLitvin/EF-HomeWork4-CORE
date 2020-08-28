using EF_HomeWork_4_CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


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

            builder.HasData(new {
                Id = 1,
                FullName = "Petrovich",
                Email = "petrovich@gmail.com",
                MobileNumber = "09923",
                TypeOfTraining = TypeOfTraining.Yoga
            });
        
        
        }
    }
}
