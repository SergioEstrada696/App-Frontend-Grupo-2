using EmpresaMetalurgicayVidrios.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmpresaMetalurgicayVidrios.Controllers
{
    public class InicioController : Controller
    {
        private readonly ILogger<InicioController> _logger;
        public InicioController(ILogger<InicioController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Inicio";
            return View();
        }
        public IActionResult Empresa()
        {
            ViewData["Title"] = "Empresa";
            return View();
        }
        public IActionResult Servicios()
        {
            ViewData["Title"] = "Servicios";
            return View();
        }
        public IActionResult Contactos()
        {
            ViewData["Title"] = "Contactos";
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
