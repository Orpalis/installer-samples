using GdPicture14.WEB;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;

namespace DocuViewareBlazor.Component.Helpers;

internal static class DocuviewareGlobals
{
    private static readonly string m_rootDirectory = Directory.GetCurrentDirectory();

    public static string GetCacheDirectory()
    {
        return Path.Combine(m_rootDirectory, @"cache");
    }

    public static string GetDocumentsDirectory()
    {
        return Path.Combine(m_rootDirectory, @"wwwroot\documents");
    }


    //**IMPORTANT** Can NOT directly use HttpContext in blazor apps. You MUST grab values from it on load of _Host page and send them as parameters into App.razor
    //  See this article https://docs.microsoft.com/en-us/aspnet/core/blazor/security/server/threat-mitigation?view=aspnetcore-6.0#blazor-and-shared-state
    //  Let's use circuitId instead
    public static string BuildDocuViewareControlSessionID(UserScopedCircuitHandler scopedCircuitHandler, string clientID)
    {
        return scopedCircuitHandler.CircuitId + clientID;
    }
    
    public static DocuViewareLocale GetDocuViewareLocale(HttpContext? httpValues)
    {
        if (httpValues != null)
        {
            var acceptLanguage = httpValues.Request.Headers.AcceptLanguage.ToList();

            if (acceptLanguage != null && acceptLanguage.Count > 0)
            {
                foreach (var language in acceptLanguage)
                {
                    DocuViewareLocale docuviewareLocale;
                    if (Enum.TryParse(language, true, out docuviewareLocale))
                    {
                        return docuviewareLocale;
                    }
                }
            }
        }

        return DocuViewareLocale.En;
    }
}
