using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Services
{
    public static class MvcServices
    {
        public static IServiceCollection AddMvcServices(this IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                options.Filters.Add(new AuthorizeFilter(policy));

            });


            services.ConfigureApplicationCookie(option =>
            {
                option.AccessDeniedPath = new PathString("/AccessDenied");
                option.LoginPath = new PathString("/account/login");
            });


            return services;
        }
    }
}
