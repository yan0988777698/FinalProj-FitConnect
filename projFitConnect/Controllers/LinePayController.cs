using Microsoft.AspNetCore.Mvc;

namespace projFitConnect.Controllers
{
    public class LinePayController : Controller
    {
        public IActionResult Products(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult Confirm()
        {
            return View();
        }

    }
}
