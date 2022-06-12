using FishTank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Persistance
{
    public static class Seed
    {
        public static void SeedDate(this ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<LivingEnvironments>(l =>
            {
                l.HasData(new LivingEnvironments()
                {
                    Id = 1,
                    Name = "Malawi Lake",
                    WaterType = "Fresh Water"
                });
            });
            modelBuilder.Entity<Fish>(f =>
            {
                f.HasData(new
                {
                    Id = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Auto Generate",
                    LivingEnvironmentId = 1,
                    StatusId = 1
                });
                f.OwnsOne(a => a.FishName).HasData(new
                {
                    FishId = 1,
                    Name = "Yellow",
                    LatinName = "Pseudotorpheus"

                });
            });
        }
    }
}
