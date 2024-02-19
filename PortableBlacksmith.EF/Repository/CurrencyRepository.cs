using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    internal class CurrencyRepository : MainRepository<CurrencyDTO>, ICurrencyRepository
    {
        private readonly PBDBContext _context;
        public CurrencyRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
