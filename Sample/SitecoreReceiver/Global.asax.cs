using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace SitecoreReceiver
{
    public class WebApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

        }
    }
}
