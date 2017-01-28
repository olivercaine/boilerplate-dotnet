using System.Web.Mvc;

namespace BaseProject.Web.Controllers
{
    public class DesignController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("applications");
        }        
        
        public ActionResult Applications()
        {
            return View();
        }

        public ActionResult Basics()
        {
            return View();
        }

        public ActionResult Components()
        {
            return View();
        }

        public ActionResult Features()
        {
            return View();
        }

        public ActionResult Principles()
        {
            return View();
        }

        public ActionResult Templates()
        {
            return View();
        }

        [Route("template-demos/{view}")]
        public ActionResult TemplateDemos(string view)
        {
            return View("~/Views/TemplateDemos/" + view + ".cshtml");
        }
    }
}