using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCosmetics.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOfTheWeek { get; set; }
    }
}
