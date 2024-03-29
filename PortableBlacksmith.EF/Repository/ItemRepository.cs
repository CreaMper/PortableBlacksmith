﻿using PortableBlacksmith.EF.Models;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF.Repository
{
    public class ItemRepository : MainRepository<ItemDTO>, IItemRepository
    {
        private readonly PBDBContext _context;
        public ItemRepository(PBDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
