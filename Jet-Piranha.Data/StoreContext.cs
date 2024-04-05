using Jet.Piranha.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Jet_Piranha.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) // Now correctly includes an identifier
        {
            base.OnModelCreating(builder); // Use the defined parameter name
            DbInitializer.Initialize(builder); // Ensure 'DbInitializer' is defined and accessible
        }
    }
}
