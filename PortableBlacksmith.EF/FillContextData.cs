using Microsoft.EntityFrameworkCore;
using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF
{
    public static class FillContextData
    {
        public static void FillWithData(PBDBContext context)
        {
            var items = new List<ItemDTO>
            {
                new ItemDTO() 
                {
                    Id = 1,
                    Base = new BaseItemDTO()
                    {
                        ID = 1,
                        Name = "Stainless Fork",
                        Type = "One-Handed"
                    }
                }
            };
            context.Item.AddRange(items);

            var itemHasModifier = new List<ItemHasModifiersDTO>()
            {
                new ItemHasModifiersDTO()
                {
                    Id = 1,
                    ItemId = 1,
                    BaseModfiers = new List<ModifierDTO>{ 
                        new ModifierDTO() 
                        {
                            Id = 1,
                            Name = "CRIT",
                            Tier = 1,
                            Value = 7
                        } 
                    },
                    PrefixModifiers = new List<ModifierDTO>{
                        new ModifierDTO()
                        {
                            Id = 2,
                            Name = "PHYS_FLAT",
                            Tier = 1,
                            Value = 10
                        }
                    },
                    SuffixModifiers = new List<ModifierDTO>{
                        new ModifierDTO()
                        {
                            Id = 3,
                            Name = "DEF_RED",
                            Tier = 1,
                            Value = 2
                        }
                    },
                }
            };

            context.ItemHasModifier.AddRange(itemHasModifier);

            context.SaveChanges();
        }
    }
}
