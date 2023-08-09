using angular15_rest_core;
using GdPicture14.WEB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

//Configure DocuVieware
var Configuration = builder.Configuration;
DocuViewareLicensing.RegisterKEY(Configuration["GDPicture:LicenceKey"]); //Unlocking DocuVieware. Please set your demo or commercial license key here or in config file.
DocuViewareManager.SetupConfiguration(Globals.STICKY_SESSION, Globals.DOCUVIEWARE_SESSION_STATE_MODE, Globals.GetCacheDirectory(), "https://localhost:7064", "api/docuvieware3");
DocuViewareEventsHandler.CustomAction += Globals.CustomActionDispatcher;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseCors(c => c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
