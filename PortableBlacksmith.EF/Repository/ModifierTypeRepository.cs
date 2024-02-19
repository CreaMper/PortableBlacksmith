
using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    public class ModifierTypeRepository : MainRepository<ModifierTypeDTO>, IModifierTypeRepository
    {
        private readonly PBDBContext _context;
        public ModifierTypeRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
