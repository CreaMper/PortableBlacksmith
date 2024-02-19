using PortableBlacksmith.EF.Repository;
using PortableBlacksmith.EF.Repository.Interfaces;

namespace PortableBlacksmith.EF
{
    public class Factory : IFactory
    {
        private readonly PBDBContext _context;
        public Factory(PBDBContext context)
        {
            _context = context;
        }

        public IBaseRepository BaseRepository { 
            get 
            { 
                return new BaseRepository(_context); 
            }
        }

        public IBaseTypeRepository BaseTypeRepository
        {
            get
            {
                return new BaseTypeRepository(_context);
            }
        }

        public ICurrencyRepository CurrenctRepository
        {
            get
            {
                return new CurrencyRepository(_context);
            }
        }

        public IItemRepository ItemRepository
        {
            get
            {
                return new ItemRepository(_context);
            }
        }

        public IMobRepository MobRepository
        {
            get
            {
                return new MobRepository(_context);
            }
        }

        public IModifierRepository ModifierRepository
        {
            get
            {
                return new ModifierRepository(_context);
            }
        }

        public IModifiersRepository ModifiersRepository
        {
            get
            {
                return new ModifiersRepository(_context);
            }
        }

        public IModifierTypeRepository ModifierTypeRepository
        {
            get
            {
                return new ModifierTypeRepository(_context);
            }
        }

        public IModifierTierRepository ModifierTierRepository
        {
            get
            {
                return new ModifierTierRepository(_context);
            }
        }

        public IUserEnergyRepository UserEnergyRepository
        {
            get
            {
                return new UserEnergyRepository(_context);
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                return new UserRepository(_context);
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
