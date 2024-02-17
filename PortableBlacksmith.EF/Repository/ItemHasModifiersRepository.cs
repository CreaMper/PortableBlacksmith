using Microsoft.EntityFrameworkCore;
using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableBlacksmith.EF.Repository
{
    public class ItemHasModifiersRepository : IItemHasModifiersRepository
    {
        private readonly PBDBContext _context;
        public ItemHasModifiersRepository(PBDBContext context)
        {
            _context = context;
        }

        public async Task<ItemHasModifiersDTO?> GetItemModifiersAsync(int itemId)
        {
            return await _context.ItemHasModifier
                .Include(y => y.SuffixModifiers)
                .Include(y => y.PrefixModifiers)
                .Include(y => y.BaseModfiers)
                .FirstOrDefaultAsync(x => x.ItemId == itemId);
        }
    }
}
