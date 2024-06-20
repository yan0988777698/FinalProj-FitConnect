using Microsoft.AspNetCore.Mvc;

namespace projFitConnect.Controllers
{
    public class FieldController : Controller
    {
        public IActionResult UpdateField(int id)
        {
            ViewBag.fieldReservedId = id;
            return View();
        }
    }
}
