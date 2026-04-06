using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Proyecto1.Services;
using Proyecto1.Services.Interface;
using Proyecto1.Models.ViewModels;

namespace Proyecto1.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductoService _productoService;
        private readonly CategoriaService _categoriaService;

        public ProductoController(ProductoService productoService,CategoriaService categoriaService)
        {
            _productoService = productoService ?? throw new ArgumentNullException(nameof(productoService));
            _categoriaService = categoriaService ?? throw new ArgumentNullException(nameof(categoriaService));
        }

        public async Task<IActionResult> Index()
        {
            var productos = await _productoService.Lista();
            return View(productos);
        }

        public async Task<IActionResult> Detalle(int id)
        {
            var producto = await _productoService.BuscarPorId(id);

            var categoria = await _categoriaService.BuscarPorId(producto.CategoriaId);

            var vm = new ProductoDetalleVM
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Imagen = producto.Imagen,
                Descripcion = producto.Descripcion,
                Precio = producto.Precio,
                CategoriaNombre = categoria.Nombre
            };

            return View(vm);
        }
    }
}
