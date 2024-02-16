using PortableBlacksmith.EF.Models;
using PortableBlacksmith.WebAPI.Converters.Interface;
using PortableBlacksmith.WebAPI.Models;

namespace PortableBlacksmith.WebAPI.Converters
{
    public class ItemConverter : IItemConverter
    {
        public ItemDto Convert(ItemDTO item)
        {
            return new ItemDto()
            {
                Id = item.Id,
                Name = $"{item.PrefixName} {item.BaseName} {item.SuffixName}"
            };
        }
    }
}
