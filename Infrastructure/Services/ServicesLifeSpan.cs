using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Database;
using DataAccess.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Services
{
    public static class ServicesLifeSpan
    {
        public static IServiceCollection AddServicesLifeSpan(this IServiceCollection services)
        {
            services.AddTransient<IPersistence, Persistence>();
            services.AddTransient<IEntity, DatabaseContext>();
            return services;
        }
    }
}
