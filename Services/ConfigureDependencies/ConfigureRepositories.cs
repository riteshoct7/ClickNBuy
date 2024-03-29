﻿using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Implementations;
using Repository.Interfaces;

namespace Services.ConfigureDependencies
{
    public class ConfigureRepositories
    {
        #region Methods

        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbConenction"));
            });
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            services.AddScoped<DbContext, ApplicationDbContext>();            
            services.AddTransient<ICategoryRepository, CategoryRepository>();
        } 

        #endregion
    }
}
