using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF.Repository.Interfaces
{
    public interface IUserEnergyRepository : IMainRepository<UserEnergyDTO>
    {
        Task<UserEnergyDTO?> GetEnergyForUserIdAsync(int id);
    }
}