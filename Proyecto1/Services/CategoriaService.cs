using Proyecto1.Helpers;
using Proyecto1.Models;
using Proyecto1.Models.Interface;
using Proyecto1.Services.Interface;

namespace Proyecto1.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly HttpClient _HttpClient;
        public CategoriaService(HttpClient httpClient)
        {
            _HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<Categoria> BuscarPorId(int Id)
        {
            var respuesta = await _HttpClient.GetAsync($"Categoria/{Id}");
            respuesta.EnsureSuccessStatusCode();
            return await respuesta.ReadContentAsync<Categoria>();
        }
    }
}
