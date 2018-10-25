using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeature.Models
{
    public class Product
    {
        public Product(bool stock=true)
        {
            InStock = stock;
        }
        public string Name { get; set; }
        public decimal?  Price { get; set; }
        public Product Related { get; set; }
        public string Category { get; set; } = "Wodniarstwo";
        public bool InStock { get; } = true;

        public static Product[] GetProducts()
        {
            Product kajak = new Product
            {
                Name = "Kajak",
                Price = 275,
                Category="Sporty wodne"
            };
            Product lifejacket = new Product(false)
            {
                Name = "Kamizelka ratunkowa",
                Price = 48.95M
            };
            kajak.Related = lifejacket;
            return new Product[] { kajak, lifejacket, null };    

        }

    }
}
