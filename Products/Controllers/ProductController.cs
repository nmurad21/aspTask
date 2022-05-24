using Microsoft.AspNetCore.Mvc;
using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id=1,
                    Name="Car",
                    Description="Mercedes...",
                    Price=15000,
                    Image="mercedes.jpg"
                },
                new Product
                {
                    Id=2,
                    Name="Phone",
                    Description="Iphone...",
                    Price=999,
                    Image="iphone.jpg"

                },
                new Product
                {
                    Id=3,
                    Name="Home",
                    Description="Villa...",
                    Price=1500000,
                    Image="villa.jpg"
                }
            };
            return View(products);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
