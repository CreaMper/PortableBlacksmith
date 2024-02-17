using PortableBlacksmith.EF.Models;
using PortableBlacksmith.WebAPI.Converters.Interface;
using PortableBlacksmith.Common.Models;
using PortableBlacksmith.Common.Utils;

namespace PortableBlacksmith.WebAPI.Converters
{
    public class ItemConverter : IItemConverter
    {
        public ItemDto Convert(ItemDTO item, ItemHasModifiersDTO mods)
        {
            return new ItemDto()
            {
                Id = item.Id,
                Name = $"{item.Base.Name}",
                Modifiers = Convert(mods)
            };
        }

        private List<ItemModifierDto> Convert(ItemHasModifiersDTO mods)
        {
            var modifierList = new List<ItemModifierDto>();

            foreach (var modifier in mods.BaseModfiers)
                modifierList.Add(Convert(modifier, ModifierTypes.BASE));

            foreach (var modifier in mods.PrefixModifiers)
                modifierList.Add(Convert(modifier, ModifierTypes.PREFIX));

            foreach (var modifier in mods.SuffixModifiers)
                modifierList.Add(Convert(modifier, ModifierTypes.SUFFIX));

            return modifierList;
        }

        private ItemModifierDto Convert (ModifierDTO modifier, ModifierTypes type)
        {
            return new ItemModifierDto()
            {
                Name = modifier.Name,
                Tier = modifier.Tier.Value,
                Type = type,
                Value = modifier.Value.Value
            };
        }
    }
}
