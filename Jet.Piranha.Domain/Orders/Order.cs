using Jet_Piranha.Domain.Catalog;

namespace Jet.Piranha.Domain.Orders
{
    public class Orders
    {
        public int Id { get; set; }
        // Initialize the Items list to ensure it's not null.
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public DateTime CreatedDate { get; set; }
        public decimal TotalPrice => Items.Sum(i => i.Price);
    }

    public class OrderItem
    {
        public int Id { get; set; }
        // Making Item nullable, see below :)
        public Item? Item { get; set; }
        public int Quantity { get; set; }
        // If Item is null, the Price is considered $0
        public decimal Price => (Item?.Price ?? 0) * Quantity;
    }
}
