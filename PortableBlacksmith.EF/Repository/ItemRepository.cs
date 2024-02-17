using Microsoft.EntityFrameworkCore;
using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly PBDBContext _context;
        public ItemRepository(PBDBContext context) 
        {
            _context = context;
        }

        public async Task<List<ItemDTO>> GetAllItemsAsync()
        {
            return await _context.Item
                .Include(x => x.Base)
                .ToListAsync();
        }

        public async Task<ItemDTO?> GetItemByIdAsync(int id)
        {
            return await _context.Item
                .Include(x => x.Base)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ItemDTO> CreateItemAsync(string baseName, string type, ModifierDTO baseModifier)
        {
            var newItem = new ItemDTO()
            {
                Base = new BaseItemDTO()
                {
                    Name = baseName,
                    Type = type
                },
                ItemHasModifiers = new ItemHasModifiersDTO()
                {
                    BaseModfiers = new List<ModifierDTO>() { baseModifier }
                }
            };

            await _context.Item.AddAsync(newItem);

            await _context.SaveChangesAsync();

            return newItem;
        }
    }
}
