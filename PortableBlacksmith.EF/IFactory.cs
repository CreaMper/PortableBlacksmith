using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF
{
    public interface IFactory
    {
        IItemRepository ItemRepository { get; }
    }
}
