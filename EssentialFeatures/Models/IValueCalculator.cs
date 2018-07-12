using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialFeatures.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);

        //Freeman, Adam.Pro ASP.NET MVC 5 (Expert's Voice in ASP.Net) (Kindle Locations 3989-3990). Apress. Kindle Edition. 
    }
}
