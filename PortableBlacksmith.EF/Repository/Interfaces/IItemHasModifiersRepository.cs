using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF.Repository.Interfaces
{
    public interface IItemHasModifiersRepository
    {
        Task<ItemHasModifiersDTO?> GetItemModifiersAsync(int itemId);
    }
}