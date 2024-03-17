using System;
using Microsoft.AspNetCore.Mvc;
using Digital.Transformation.Domain.Catalog;

namespace Digital.Transformation.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world.");
        }
    }
}

namespace Digital.Transformation.Domain.Catalog
{

    public class Rating
    {
        public int Stars { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }

        public Rating(int stars, string userName, string review)
        {
            if(stars < 1 || stars > 5)
            {
                throw new ArgumentException("Star rating must be an integer of: 1, 2, 3, 4, 5");
            }

            if(string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("UserName cannot be null.");
            }
            
            this.Stars = stars;
            this.UserName = userName;
            this.Review = review;
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public List<Rating> Ratings { get; set; } = new List<Rating>();

        public void AddRating(Rating rating)
        {
            this.Ratings.Add(rating);
        }

        public Item(string name, string description, string brand, decimal price)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name);
            }

            if(string.IsNullOrEmpty(brand))
            {
                throw new ArgumentNullException(brand);
            }
            
            if(price < 0.00m)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }
            Name = name;
            Description = description;
            Brand = brand;
            Price = price;
        }
    }
}


