using Jet.Piranha.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Jet_Piranha.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }

            protected override void OnModelCreating(ModelBuilder)
            {
                base.OnModelCreating(builder);
                DbInitializer.Initialize(builder);
            }
    }
}
