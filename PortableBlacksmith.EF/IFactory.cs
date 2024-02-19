using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF
{
    public interface IFactory
    {
        IBaseRepository BaseRepository { get; }
        IBaseTypeRepository BaseTypeRepository { get; }
        ICurrencyRepository CurrenctRepository { get; }
        IItemRepository ItemRepository { get; }
        IMobRepository MobRepository { get; }
        IModifierRepository ModifierRepository { get; }
        IModifiersRepository ModifiersRepository { get; }
        IModifierTypeRepository ModifierTypeRepository { get; }
        IModifierTierRepository ModifierTierRepository { get; }
        IUserEnergyRepository UserEnergyRepository { get; }
        IUserRepository UserRepository { get; }

        Task SaveChangesAsync();
    }
}
