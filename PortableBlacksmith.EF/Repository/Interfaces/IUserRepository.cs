using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF.Repository.Interfaces
{
    public interface IUserRepository : IMainRepository<UserDTO>
    {
        Task<UserDTO?> GetUserByIdAsync(int id);
    }
}