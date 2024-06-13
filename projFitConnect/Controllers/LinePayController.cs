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
        [HttpPost]
        public IActionResult Pay(PayVM payVM)
        {
            return View(payVM);
        }
        public IActionResult Confirm()
        {
            return View();
        }

    }
}
