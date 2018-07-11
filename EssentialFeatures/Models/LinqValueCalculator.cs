using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialFeatures.Models
{
    public class LinqValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }

        //Freeman, Adam.Pro ASP.NET MVC 5 (Expert's Voice in ASP.Net) (Kindle Locations 3896-3899). Apress. Kindle Edition. 
    }
}