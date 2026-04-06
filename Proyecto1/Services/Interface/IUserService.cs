using Proyecto1.Models;

namespace Proyecto1.Services.Interface
{
    public interface IUserService
    {
        Task<IEnumerable<User>> Lista();
    }
}
