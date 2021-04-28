using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Services.ConfigureDependencies;
using System.Collections.Generic;
using System.Globalization;
using UI.ConfigureDependencies;

namespace UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddMvc()
            .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            .AddDataAnnotationsLocalization()
            .AddMvcLocalization();

            services.Configure<RequestLocalizationOptions>( opts =>
            {
               var supportedCultures = new List<CultureInfo>
               {
                    new CultureInfo("en"),
                    new CultureInfo("fr"),
                    new CultureInfo("hi-IN"),
                    new CultureInfo("ba-RU"),
                    new CultureInfo("ar-SA"),
                    new CultureInfo("gu-IN")
               };
               opts.DefaultRequestCulture = new RequestCulture("en");
               opts.SupportedCultures = supportedCultures;
               opts.SupportedUICultures = supportedCultures;
           });

            //var cultureInfo = new CultureInfo("ar-SA"); //arabic
            //var cultureInfo = new CultureInfo("hi-IN"); //Hindi
            // var cultureInfo = new CultureInfo("gu-IN"); // Gujarati
            //var cultureInfo = new CultureInfo("ba-RU"); //Russian
            //var cultureInfo = new CultureInfo("fr"); //French
            //CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            //CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;


            //services.AddControllersWithViews().
            //    AddMvcLocalization()
            //    .AddViewLocalization()
            //    .AddDataAnnotationsLocalization();

            ConfigureRepositories.AddServices(services, Configuration);
            ConfigureServiceDepenedencies.AddServices(services);
            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            var requestlocalizationOptions = app.ApplicationServices.
                GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(requestlocalizationOptions.Value);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
