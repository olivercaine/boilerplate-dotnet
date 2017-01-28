using System.Web;

namespace BaseProject.Web.Utilities
{
    public static class Urls
    {
        public static string AbsoluteUri
        {
            get
            {
                var url = HttpContext.Current.Request.Url;
                return url.AbsoluteUri.Replace(url.PathAndQuery, "/");
            }
        }

        public static string ActiveClassIfCurrent(string url)
        {
            return (HttpContext.Current.Request.Url.AbsolutePath.Contains(url)) ? "class=active" : string.Empty;
        }
    }
}