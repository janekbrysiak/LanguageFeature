using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeature.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeature.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productsArray = {
                new Product { Name = "Kajak", Price = 275M },
                new Product{Name="Kamizelka ratunkowa",Price=48.95M},
                new Product {Name="Flaga narożna",Price=34.95M },
                new Product  {Name="Piłka nożna",Price=19.50M}
            };
            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productsArray.FilterByPrice(20).TotalPrices();

            return View("Index", new string[]
            {
                $"Razem koszyk:{cartTotal:C2}",
                $"Razem tablica:{arrayTotal:C2}"
            });
        }

    }
}