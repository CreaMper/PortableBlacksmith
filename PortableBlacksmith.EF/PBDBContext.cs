using Microsoft.EntityFrameworkCore;
using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF
{
    public class PBDBContext : DbContext
    {
        public DbSet<ItemDTO> Items { get; set; }

        public PBDBContext(DbContextOptions<PBDBContext> options) : base(options)
        {
            DBInit.Init(this);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("EmbeddedDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemDTO>();
        }
    }
}