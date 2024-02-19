using Microsoft.EntityFrameworkCore;
using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF
{
    public class PBDBContext : DbContext
    {
        public DbSet<BaseDTO> Base { get; set; }
        public DbSet<BaseHasModifierDTO> BaseHasModifier { get; set; }
        public DbSet<BaseTypeDTO> BaseType { get; set; }
        public DbSet<CurrencyDTO> Currency { get; set; }
        public DbSet<ItemDTO> Item { get; set; }
        public DbSet<ItemHasModifierDTO> ItemHasModifier { get; set; }
        public DbSet<MobDTO> Mob { get; set; }
        public DbSet<ModifierDTO> Modifier { get; set; }
        public DbSet<ModifiersDTO> Modifiers { get; set; }
        public DbSet<ModifierTierDTO> ModifierTier { get; set; }
        public DbSet<ModifierTypeDTO> ModifierType { get; set; }
        public DbSet<UserDTO> User { get; set; }
        public DbSet<UserEnergyDTO> UserEnergy { get; set; }
        public DbSet<UserHasItem> UserHasItem { get; set; }

        public PBDBContext(DbContextOptions<PBDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public void InitialDataFill()
        {
            FillContextData.FillWithData(this);
        }
    }
}