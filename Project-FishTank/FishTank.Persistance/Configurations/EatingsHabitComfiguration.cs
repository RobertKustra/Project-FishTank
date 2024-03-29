﻿using FishTank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Persistance.Configurations
{
    internal class EatingsHabitComfiguration : IEntityTypeConfiguration<EatingsHabits>
    {
        public void Configure(EntityTypeBuilder<EatingsHabits> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
