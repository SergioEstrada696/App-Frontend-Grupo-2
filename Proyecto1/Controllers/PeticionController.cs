using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto1.Models;
using Proyecto1.Services;
using Proyecto1.Services.Interface;


namespace Proyecto1.Controllers
{
    public class PeticionController : Controller
    {
        private readonly PeticionService _peticionService;
        private readonly ClienteService _clienteService;

        public PeticionController( PeticionService peticionService,ClienteService clienteService)
        {
            _peticionService = peticionService;
            _clienteService = clienteService;
        }
        [HttpGet]
        public async Task<IActionResult> Create(int id)
        {
            var clientes = await _clienteService.Lista();
            ViewBag.Clientes = clientes.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.CodigoCliente ?? "Sin código"
            }).ToList();

            return View(new Peticion { ProductoId = id });
        }
        [HttpPost]
        public async Task<IActionResult> Create(Peticion peticion)
        {
            if (!ModelState.IsValid)
            {
                var clientes = await _clienteService.Lista();
                ViewBag.Clientes = new SelectList(clientes ?? new List<Cliente>(), "Id", "Nombre");

                return View(peticion);
            }

            peticion.Estado = true;

            await _peticionService.Create(peticion);

            TempData["Success"] = "Su petición fue realizada exitosamente";

            return RedirectToAction("Index", "Producto");
        }
    }
}
