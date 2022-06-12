using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Persistance
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FishDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("FishDataBase")));
            return services;
        }
    }
}
