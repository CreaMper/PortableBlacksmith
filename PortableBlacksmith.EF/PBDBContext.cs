using Microsoft.EntityFrameworkCore;
using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF
{
    public class PBDBContext : DbContext
    {
        public DbSet<ItemDTO> Items { get; set; }

        public PBDBContext(DbContextOptions<PBDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemDTO>();
        }

        public void InitialDataFill()
        {
            FillContextData.FillWithData(this);
        }
    }
}