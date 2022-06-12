using FishTank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Persistance.Configurations
{
    internal class LivingEnvironmentsConfiguration : IEntityTypeConfiguration<LivingEnvironments>
    {
        public void Configure(EntityTypeBuilder<LivingEnvironments> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(20)
                .IsRequired();
            builder.Property(p => p.WaterType)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
