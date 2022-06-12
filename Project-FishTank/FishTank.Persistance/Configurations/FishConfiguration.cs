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
    public class FishConfiguration : IEntityTypeConfiguration<Fish>
    {
        public void Configure(EntityTypeBuilder<Fish> builder)
        {
            builder.OwnsOne(a => a.FishName).Property(a => a.Name)
                .HasColumnName("Name")
                .IsRequired().HasMaxLength(20);
            builder.OwnsOne(a => a.FishName).Property(a => a.LatinName)
                .HasColumnName("LatinName")
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
