using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    internal class ModifiersRepository : MainRepository<ModifiersDTO>, IModifiersRepository
    {
        private readonly PBDBContext _context;
        public ModifiersRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
