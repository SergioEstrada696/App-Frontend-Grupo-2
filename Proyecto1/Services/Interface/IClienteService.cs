using Proyecto1.Models;

namespace Proyecto1.Services.Interface
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> Lista();
    }
}
