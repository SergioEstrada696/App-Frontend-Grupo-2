using Proyecto1.Helpers;
using Proyecto1.Models;
using Proyecto1.Services.Interface;

namespace Proyecto1.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _HttpClient;
        public UserService(HttpClient httpClient)
        {
            _HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<User>> Lista()
        {
            var respuesta = await _HttpClient.GetAsync("User");
            return await respuesta.ReadContentAsync<List<User>>();
        }
    }
}
