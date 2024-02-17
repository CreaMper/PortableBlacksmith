using PortableBlacksmith.EF.Models;
using PortableBlacksmith.WebAPI.Models;

namespace PortableBlacksmith.WebAPI.Converters.Interface
{
    public interface IItemConverter
    {
        ItemDto Convert(ItemDTO item, ItemHasModifiersDTO mods);
    }
}