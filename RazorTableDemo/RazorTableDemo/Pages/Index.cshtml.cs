using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorTableDemo.Models;
using System.Collections.Generic;

namespace RazorTableDemo.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 80000 },
                new Product { Id = 2, Name = "Smartphone", Price = 50000 },
                new Product { Id = 3, Name = "Tablet", Price = 30000 }
            };
        }
    }
}
