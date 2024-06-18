using Microsoft.AspNetCore.Mvc;
using projFitConnect.ViewModels;

namespace projFitConnect.Controllers
{
    public class LinePayController : Controller
    {
        public IActionResult shoppingCart(int id)
        {
            ViewBag.memberId = id;
            return View();
        }
        public IActionResult CourseShoppingCart(int id)
        {
            ViewBag.coachId = id;
            return View();
        }
        [HttpPost]
        public IActionResult Pay(PayVM payVM)
        {
            return View(payVM);
        }
        [HttpPost]
        public IActionResult PayforCourse([FromForm] PayforCourseVM payforCourseVM)
        {
            return View(payforCourseVM);
        }
        public IActionResult Confirm()
        {
            return View();
        }

    }
}
