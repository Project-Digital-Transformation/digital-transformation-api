using Jet.Piranha.Domain.Catalog;
using Jet.Piranha.Domain.Orders; // Added this line bc Orders class is in this namespace
using Microsoft.EntityFrameworkCore;

namespace Jet_Piranha.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        // Existing DbSet for Items
        public DbSet<Item> Items { get; set; }

        // Add this line to include a DbSet for Orders
        public DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder); // Ensure 'DbInitializer' is defined and accessible
        }
    }
}
