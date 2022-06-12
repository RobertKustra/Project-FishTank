using FishTank.Application.Common.Interfaces;
using FishTank.Domain.Common;
using FishTank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Persistance
{
    public class FishDbContext : DbContext
    {
        private readonly IDateTime _datetime;

        public FishDbContext(DbContextOptions<FishDbContext> options, IDateTime dateTime ) : base(options)
        {
            _datetime = dateTime;
        }

        public DbSet<Fish> Fish { get; set; }
        public DbSet<EatingsHabits> EatingsHabits { get; set; }
        public DbSet<LivingEnvironments> LivingEnvironments { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedDate();

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach(var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = _datetime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _datetime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _datetime.Now;
                        entry.Entity.Inactivated = _datetime.Now;
                        entry.Entity.InactivatedBy = String.Empty;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;

                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
