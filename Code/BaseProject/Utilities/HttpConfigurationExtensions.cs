using System.Net.Http.Headers;
using System.Web.Http;

namespace BaseProject.Web.Utilities
{
    public static class HttpConfigurationExtensions
    {
        // WebAPI defaults to returning XML which seems to have problems serialising.
        // This forces WebAPI to return JSON when text/html is requested. 
        // Might need to revisit this if clients needs XML but ignore it for the moment as XML is ineffecient anyway.
        public static void ReturnJsonWhenRequestingText(this HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}