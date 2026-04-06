using Proyecto1.Models;

namespace Proyecto1.Services.Interface
{
    public interface IPeticionService
    {
        Task Create(Peticion peticion);
    }
}
