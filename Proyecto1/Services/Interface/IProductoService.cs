using Proyecto1.Models;

namespace Proyecto1.Services.Interface
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> Lista();
        Task<Producto> BuscarPorId(int id);
    }
}
