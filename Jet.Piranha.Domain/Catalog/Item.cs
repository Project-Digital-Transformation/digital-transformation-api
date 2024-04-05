using System;
using Emerald.Tiger.Domain.Catalog;
using System.Runtime.Versioning; //page 5



namespace Jet.Piranha.Domain.Catalog
{
    public class Item //page 5
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public List<Rating>? Ratings { get; set; } = new List<Rating>();
        public void AddRating(Rating rating)
        {
            this.Ratings.Add(rating);
        }

        public Item(string name, string description, string brand, decimal price)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name);
            }
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException(description);
            }
            if (string.IsNullOrEmpty(brand))
            {
                throw new ArgumentException(brand);
            }
            if (price < 0.00m)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }

            //constructor variables i think
            Name = name;
            Description = description;
            Brand = brand;
            Price = price;
            Ratings = new List<Rating>();

        }
        
    }



}