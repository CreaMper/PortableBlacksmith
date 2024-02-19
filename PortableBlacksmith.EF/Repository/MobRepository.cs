using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;


namespace PortableBlacksmith.EF.Repository
{
    internal class MobRepository : MainRepository<MobDTO>, IMobRepository
    {
        private readonly PBDBContext _context;
        public MobRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
