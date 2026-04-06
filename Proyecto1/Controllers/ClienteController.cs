using Microsoft.AspNetCore.Mvc;
using Proyecto1.Services;

namespace Proyecto1.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteService _clienteService;
        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        public async Task<IActionResult> Index()
        {
            var clientes = await _clienteService.Lista();
            return View(clientes);
        }
    }
}
