using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    public class BaseTypeRepository : MainRepository<BaseTypeDTO>, IBaseTypeRepository
    {
        private readonly PBDBContext _context;
        public BaseTypeRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
