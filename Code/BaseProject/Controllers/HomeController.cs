using System.Web.Mvc;
using BaseProject.Web.Services;

namespace BaseProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SitemapService sitemapService = new SitemapService();

        public ActionResult Index()
        {
            return RedirectToAction("Info");
        }

        [Route("development")]
        public ActionResult Development()
        {
            return View();
        }

        [Route("info")]
        public ActionResult Info()
        {
            return View();
        }

        [Route("robots.txt")]
        public ActionResult Robots()
        {
            Response.ContentType = "text/plain";
            return View();
        }

        [Route("sitemap")]
        public ActionResult Sitemap()
        {
            return View(sitemapService.SitemapPages());
        }

        [Route("sitemapxml")]
        public ActionResult SitemapXml()
        {
            Response.ContentType = "application/xml";
            return View(sitemapService.SitemapUrls());
        }

        [Route("tests")]
        public ActionResult Tests()
        {
            return View();
        }
    }
}