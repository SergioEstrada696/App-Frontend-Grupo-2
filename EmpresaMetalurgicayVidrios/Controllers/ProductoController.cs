using Microsoft.AspNetCore.Mvc;

namespace EmpresaMetalurgicayVidrios.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Productos";
            return View();
        }
    }
}
