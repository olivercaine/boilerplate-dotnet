using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BaseProject.Web
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_PreSendRequestHeaders()
        {
            Response.Headers.Remove("X-AspNet-Version");
            Response.Headers.Remove("X-AspNetMvc-Version");
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            StylesConfig.ConfigureBundles(BundleTable.Bundles);
            ScriptsConfig.ConfigureBundles(BundleTable.Bundles);
        }
    }
}