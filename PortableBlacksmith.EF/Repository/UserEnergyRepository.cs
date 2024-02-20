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
            var userEnergy = await _context.UserEnergy.FirstOrDefaultAsync(x => x.UserId == id);

            //calculate if energy recovered
            var differenceInSeconds = (DateTime.UtcNow - userEnergy.Updated).TotalSeconds;
            if (userEnergy.Current < userEnergy.Max)
            {
                userEnergy.Current += (int)Math.Floor(differenceInSeconds / 2);
                if (userEnergy.Current > userEnergy.Max)
                    userEnergy.Current = userEnergy.Max;

                userEnergy.Updated = DateTime.UtcNow;
                _context.UserEnergy.Update(userEnergy);
            }

            return userEnergy;
        }
    }
}
