﻿using Microsoft.Extensions.DependencyInjection;
using Services.Implementations;
using Services.Interfaces;

using Resources;

namespace UI.ConfigureDependencies
{
    public class ConfigureServiceDepenedencies
    {
        #region Methods

        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticateService, AuthenticateService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddSingleton<IAppResource, SharedResources>();
        } 

        #endregion
    }
}
