using DocuViewareBlazor.Component.Configuration;
using DocuViewareBlazor.Component.Controllers;
using DocuViewareBlazor.Component.Helpers;
using GdPicture14.WEB;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Builder
{
    public static class DocuviewareBuilderExtentions
    {
        public static IServiceCollection AddDocuVieware(this IServiceCollection services, Action<DocuViewareConfiguration> configure)
        {
            if (configure is null)
            {
                throw new ArgumentNullException(nameof(configure));
            }

            var options = new DocuViewareConfiguration();
            configure(options);
            services.AddSingleton(options);

            DocuViewareLicensing.RegisterKEY(options.LicenseKey);
            DocuViewareManager.SetupConfiguration(options.StickySession, options.SessionMode, options.CacheDirectory, options.ApplicationURI, options.ControllerRoute);

            services.AddScoped<CircuitHandler, UserScopedCircuitHandler>();
            services.AddTransient<DocuVieware3Controller>();

            services.AddMvcCore().AddControllersAsServices().AddApplicationPart(typeof(DocuVieware3Controller).Assembly);
            
            return services;
        }

        public static IApplicationBuilder UseDocuVieware(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
            return app;
        }
    }
}
