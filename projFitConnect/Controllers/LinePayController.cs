using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Pay(int sum)
        {
            ViewBag.sum = sum;
            return View();
        }
        public IActionResult Confirm()
        {
            return View();
        }

    }
}
