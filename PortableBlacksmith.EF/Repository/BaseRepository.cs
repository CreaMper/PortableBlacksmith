using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    public class BaseRepository : MainRepository<BaseDTO>, IBaseRepository
    {
        private readonly PBDBContext _context;
        public BaseRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
