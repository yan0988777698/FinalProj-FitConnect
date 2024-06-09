using Microsoft.AspNetCore.Mvc;

namespace projFitConnect.Controllers
{
    public class SchduleController : Controller
    {
        public IActionResult Update(int? id)
        {
            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        public IActionResult Update()
        {
            return RedirectToAction("Profile", "Coach");
        }
    }
}
