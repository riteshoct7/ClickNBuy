using Microsoft.Extensions.DependencyInjection;
using Services.Implementations;
using Services.Interfaces;

namespace WebApi.ConfigureDependencies
{
    public class ConfigureServiceDepenedencies
    {
        #region Methods

        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticateService, AuthenticateService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }

        #endregion
    }
}
