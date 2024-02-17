using Microsoft.EntityFrameworkCore;
using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF
{
    public class PBDBContext : DbContext
    {
        public DbSet<ItemDTO> Item { get; set; }
        public DbSet<BaseItemDTO> BaseItem { get; set; }
        public DbSet<ItemHasModifiersDTO> ItemHasModifier { get; set; }
        public DbSet<ModifierDTO> Modifier { get; set; }

        public PBDBContext(DbContextOptions<PBDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemHasModifiersDTO>()
                .HasMany(item => item.BaseModfiers)
                .WithOne(modifier => modifier.BaseModifier)
                .HasForeignKey(modifier => modifier.BaseModifierId);

            modelBuilder.Entity<ItemHasModifiersDTO>()
                .HasMany(item => item.PrefixModifiers)
                .WithOne(modifier => modifier.PrefixModifier)
                .HasForeignKey(modifier => modifier.PrefixModifierId);

            modelBuilder.Entity<ItemHasModifiersDTO>()
                .HasMany(item => item.SuffixModifiers)
                .WithOne(modifier => modifier.SuffixModifier)
                .HasForeignKey(modifier => modifier.SuffixModifierId);
        }

        public void InitialDataFill()
        {
            //FillContextData.FillWithData(this);
        }
    }
}