using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using AutoMapper;
using Infrastructure.Interns.Profiles;
using Infrastructure.Restaurants.Profiles;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Services
{
    public static class AddExtraService
    {
        public static IServiceCollection AddExtraServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<InternProfile>();
                c.AddProfile<RestaurantProfile>();
            });
            services.AddSingleton<IMapper>(s => config.CreateMapper());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddHttpContextAccessor();
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
                options.EnableForHttps = true;
            });
            return services;
        }
    }
}
