using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    public class ModifierRepository : MainRepository<ModifierDTO>, IModifierRepository
    {
        private readonly PBDBContext _context;
        public ModifierRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
