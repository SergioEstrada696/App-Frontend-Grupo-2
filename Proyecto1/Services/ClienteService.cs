using Proyecto1.Helpers;
using Proyecto1.Models;
using Proyecto1.Models.Interface;
using Proyecto1.Services.Interface;

namespace Proyecto1.Services
{
    public class ClienteService : IClienteService
    {
        private readonly HttpClient _HttpClient;
        public ClienteService(HttpClient httpClient)
        {
            _HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<Cliente>> Lista()
        {
            var respuesta = await _HttpClient.GetAsync("Cliente");
            return await respuesta.ReadContentAsync<List<Cliente>>();
        }
    }
}
