using System.Web.Http;
using BaseProject.Web.Utilities;

namespace BaseProject.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.ReturnJsonWhenRequestingText();

            RegisterBaseProjectRoutes(config);
        }

        private static void RegisterBaseProjectRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
        }
    }
}