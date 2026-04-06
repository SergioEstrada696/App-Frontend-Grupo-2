using Proyecto1.Models;

namespace Proyecto1.Services.Interface
{
    public interface ICategoriaService
    {
        Task<Categoria> BuscarPorId(int id);
    }
}
