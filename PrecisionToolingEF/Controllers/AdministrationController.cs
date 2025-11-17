using Microsoft.AspNetCore.Mvc;

namespace PrecisionToolingEF.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Index()
        {
            return View("AdminEmployees");
        }

        public IActionResult Employees()
        {
            return View("AdminEmployees");
        }

        public IActionResult Payroll()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View("AdminSettings");
        }
    }
}
