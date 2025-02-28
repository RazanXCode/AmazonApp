using AmazonApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Controllers
{
    [Route("Products")]
    public class ProductController : Controller
    {
      
        private static List<Product> Products = new List<Product>
        {
            new Product { ProductID = 1, Name = "Laptop", Category = "Electronics", Price = 1200, StockQuantity = 10 },
            new Product { ProductID = 2, Name = "Smartphone", Category = "Electronics", Price = 800, StockQuantity = 20 },
            new Product { ProductID = 3, Name = "Headphones", Category = "Accessories", Price = 150, StockQuantity = 50 },
            new Product { ProductID = 4, Name = "Tablet", Category = "Electronics", Price = 600, StockQuantity = 15 }
        };

        // GET: /Products
        [HttpGet]
        public IActionResult Index()
        {
            return View(Products); // Return the list of products to the view
        }
    }
}
