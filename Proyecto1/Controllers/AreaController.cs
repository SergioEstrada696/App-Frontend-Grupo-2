using Microsoft.AspNetCore.Mvc;

namespace Proyecto1.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
