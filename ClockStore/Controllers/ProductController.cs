using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClockStore.Models;

namespace ClockStore.Controllers
{
    public class ProductController : Controller
    {

        private List<Product> _products;

        public ProductController()
        {
            //for now using a list to mockup product data

            _products = new List<Product>();

            _products.Add(new Product
            {
                ID=1,
                Name="Antique Clock",
                Description="Old Wooden Clock",
                Image="",
                Price=100m
            });

            _products.Add(new Product
            {
                ID = 2,
                Name = "Modern Clock",
                Description = "Digital Clock",
                Image = "",
                Price = 50m
            });

        }

        public IActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Product p = _products.Single(x => x.ID == id.Value);
                return View(p);
            }
            return NotFound();
        }

        public IActionResult Index()
        {
            return View(_products);
        }
    }
}