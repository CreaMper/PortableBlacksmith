using PortableBlacksmith.EF.Repository;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF
{
    public class Factory : IFactory
    {
        private readonly PBDBContext _context;
        public Factory(PBDBContext context)
        {
            _context = context;
        }

        public IItemRepository ItemRepository { 
            get 
            { 
                return new ItemRepository(_context); 
            }
        }
    }
}
