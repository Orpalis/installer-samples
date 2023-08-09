using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GdPicture14.WEB;
using System.IO;

namespace DocuViewareDemo
{
    public class Startup
    {
        const string APP_URI = "http://localhost:5000";

        public Startup(IConfiguration configuration)
        {
            DocuViewareLicensing.RegisterKEY("");
            Configuration = configuration;
            DocuViewareManager.SetupConfiguration(true, Globals.DOCUVIEWARE_SESSION_STATE_MODE, Path.Combine(Globals.GetCacheDirectory(), "/", "api/docuvieware3"), APP_URI, "api/docuvieware3");
            DocuViewareEventsHandler.CustomAction += Globals.CustomActionHandler;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();
            app.UseCors(options => options
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
