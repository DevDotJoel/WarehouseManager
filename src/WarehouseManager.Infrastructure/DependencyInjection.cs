using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Application.Common.Persistence;
using WarehouseManager.Infrastructure.Common.Persistence;
using WarehouseManager.Infrastructure.Common.Persistence.Repositories;

namespace WarehouseManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistence();
            return services;
        }
        private static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<WarehouseManagerContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
            services.AddScoped<IWarehouseSlotRepository, WarehouseSlotRepository>();
            return services;
        }
    }
}
