using Microsoft.AspNetCore.Mvc;
using ProductListApp.Models;

namespace ProductListApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Sample list of products
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m, Description = "High performance laptop." },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99m, Description = "Latest model smartphone." },
                new Product { Id = 3, Name = "Headphones", Price = 199.99m, Description = "Noise-cancelling headphones." }
            };

            return View(products);
        }
    }
}
