using PortableBlacksmith.EF.Models;

using PortableBlacksmith.EF.Repository.Interfaces;
namespace PortableBlacksmith.EF.Repository
{
    internal class ModifierTierRepository : MainRepository<ModifierTierDTO>, IModifierTierRepository
    {
        private readonly PBDBContext _context;
        public ModifierTierRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }
    }
}

