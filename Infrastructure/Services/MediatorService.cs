using System.IO.Compression;
using System.Reflection;
using AutoMapper;
using Infrastructure.ContractPayments.Profiles;
using Infrastructure.Contracts.Profiles;
using Infrastructure.Employees.Profiles;
using Infrastructure.Fails.Profiles;
using Infrastructure.Interns.Profiles;
using Infrastructure.Positions.Profiles;
using Infrastructure.Products.Profiles;
using Infrastructure.RestaurantContacts.Profiles;
using Infrastructure.RestaurantMeetings.Profiles;
using Infrastructure.Restaurants.Profiles;
using Infrastructure.Roles.Profiles;
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
                c.AddProfile<PositionProfile>();
                c.AddProfile<EmployeeProfile>();
                c.AddProfile<RoleProfile>();
                c.AddProfile<ProductProfile>();
                c.AddProfile<FailProfile>();
                c.AddProfile<RestaurantContactProfile>();
                c.AddProfile<ContractProfile>();
                c.AddProfile<ContractPaymentProfile>();
                c.AddProfile<RestaurantMeetingProfile>();
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
