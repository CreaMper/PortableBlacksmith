using Microsoft.EntityFrameworkCore;
using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    public class UserEnergyRepository : MainRepository<UserEnergyDTO>, IUserEnergyRepository
    {
        private readonly PBDBContext _context;
        public UserEnergyRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<UserEnergyDTO?> GetEnergyForUserIdAsync(int id)
        {
            var user = await _context.UserEnergy.FirstOrDefaultAsync(x => x.UserId == id);
            return user;
        }
    }
}
