using System.Web.Mvc;
using BaseProject.Web.ViewModels;

namespace BaseProject.Web.Controllers
{
    public class SharedController : Controller
    {
        public ViewResult PhoneAdvert(PhoneAdvertViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}