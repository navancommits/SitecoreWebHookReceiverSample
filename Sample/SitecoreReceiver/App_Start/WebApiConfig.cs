using System.Web.Http;

namespace SitecoreReceiver
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Initialize Sitecore WebHook receiver
            config.InitializeReceiveSitecoreJsonWebHooks();
        }
    }
}
