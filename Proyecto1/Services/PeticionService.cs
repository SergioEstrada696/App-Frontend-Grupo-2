using Proyecto1.Models;
using Proyecto1.Services.Interface;

namespace Proyecto1.Services
{
    public class PeticionService : IPeticionService
    {
        private readonly HttpClient _HttpClient;
        public PeticionService(HttpClient httpClient)
        {
            _HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task Create(Peticion peticion)
        {
            var response = await _HttpClient.PostAsJsonAsync("Peticion", peticion);
            response.EnsureSuccessStatusCode();
        }

    }
}
