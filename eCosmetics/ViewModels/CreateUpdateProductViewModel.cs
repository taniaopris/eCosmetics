using eCosmetics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCosmetics.ViewModels
{
    public class CreateUpdateProductViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
        public string CategoryName { get; set; }
    }
}
