﻿using Microsoft.EntityFrameworkCore;
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
    }
}
