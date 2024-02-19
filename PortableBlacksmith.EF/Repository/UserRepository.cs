using Microsoft.EntityFrameworkCore;
using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    public class UserRepository : MainRepository<UserDTO>, IUserRepository
    {
        private readonly PBDBContext _context;
        public UserRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<UserDTO?> GetUserByIdAsync(int id) 
        {
            var user = await _context.User.
                Include(x => x.Wallet).FirstOrDefaultAsync(x => x.Id == id);
            
            return user;
        }
    }
}
