using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Persistance
{
    public class FishTankDbContextFactory : DesignTimeDbContextFactoryBase<FishDbContext>
    {

        protected override FishDbContext CreateNewInstance(DbContextOptions<FishDbContext> options)
        {
            return new FishDbContext(options);
        }
    }
}
