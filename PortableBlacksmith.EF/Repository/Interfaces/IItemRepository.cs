using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF.Repository.Interfaces
{
    public interface IItemRepository
    {
        Task<List<ItemDTO>> GetAllItemsAsync();
        Task<ItemDTO?> GetItemByIdAsync(int id);
        Task<ItemDTO> CreateItemAsync(string baseName, string type, ModifierDTO baseModifier);
    }
}
