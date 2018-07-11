using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialFeatures.Models
{
    public class ShoppingCart
    {
        private LinqValueCalculator calc;
        public ShoppingCart(LinqValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }

        //Freeman, Adam.Pro ASP.NET MVC 5 (Expert's Voice in ASP.Net) (Kindle Locations 3912-3919). Apress. Kindle Edition. 
    }
}