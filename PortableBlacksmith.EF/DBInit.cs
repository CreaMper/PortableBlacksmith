using Microsoft.EntityFrameworkCore;
using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF
{
    public static class DBInit
    {
        public static void Init(PBDBContext context)
        {
            var items = new List<ItemDTO>
            {
                new ItemDTO() { Id = 1, BaseName = "Stainless Armour", PrefixName = "Greater", SuffixName = null }
            };
            context.Items.AddRange(items);

            context.SaveChanges();
        }
    }
}
