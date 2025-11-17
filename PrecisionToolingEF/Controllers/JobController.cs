using Microsoft.AspNetCore.Mvc;

namespace PrecisionToolingEF.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JobGeneral()
        {
            return View();
        }

        public IActionResult Labor()
        {
            return View();
        }

        public IActionResult Material()
        {
            return View();
        }

        public IActionResult EditLabor()
        {
            return View("EditLabor");
        }

        public IActionResult EditMaterial()
        {
            return View("EditMaterialView");
        }

        public IActionResult EditGeneral()
        {
            return View("EditGeneralView");
        }
    }
}
