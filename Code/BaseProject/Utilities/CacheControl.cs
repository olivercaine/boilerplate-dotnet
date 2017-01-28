using System;
using System.Net.Http.Headers;
using System.Web.Http.Filters;

namespace BaseProject.Web.Utilities
{
    public class CacheControl : ActionFilterAttribute
    {
        public CacheControl()
        {
            MaxAge = 3600;
        }

        public int MaxAge { get; set; }

        public override void OnActionExecuted(HttpActionExecutedContext context)
        {
            context.Response.Headers.CacheControl = new CacheControlHeaderValue
            {
                Public = true,
                MaxAge = TimeSpan.FromSeconds(MaxAge)
            };
           
            base.OnActionExecuted(context);
        }
    }
}