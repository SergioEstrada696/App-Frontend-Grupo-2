using Proyecto1.Helpers;
using Proyecto1.Models;
using Proyecto1.Services.Interface;

namespace Proyecto1.Services
{
    public class ProductoService : IProductoService
    {
        private readonly HttpClient _HttpClient;
        public ProductoService(HttpClient httpClient)
        {
            _HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<Producto>> Lista()
        {
            var respuesta = await _HttpClient.GetAsync("Producto");
            return await respuesta.ReadContentAsync<List<Producto>>();
        }
        public async Task<Producto> BuscarPorId(int Id)
        {
            var respuesta = await _HttpClient.GetAsync($"Producto/{Id}");
            respuesta.EnsureSuccessStatusCode();
            return await respuesta.ReadContentAsync<Producto>();
        }
    }
}
