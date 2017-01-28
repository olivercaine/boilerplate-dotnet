using System.Net;
using System.Web.Mvc;

namespace BaseProject.Web.Controllers
{
    [RoutePrefix("Errors")]
    public class ErrorsController : Controller
    {
        [Route("page-not-found")]
        public ViewResult PageNotFound()
        {
            Response.StatusCode = (int)HttpStatusCode.NotFound;
            return View();
        }

        [Route("server-error")]
        public ViewResult ServerError()
        {
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return View();
        }
    }
}