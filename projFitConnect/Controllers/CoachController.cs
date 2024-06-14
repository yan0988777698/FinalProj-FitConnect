using Microsoft.AspNetCore.Mvc;

namespace projFitConnect.Controllers
{
    public class CoachController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult CreateCourse()
        {
            ViewBag.id = 6;
            return View();
        }
    }
}
