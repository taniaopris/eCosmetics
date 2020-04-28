using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCosmetics.Models;
using eCosmetics.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCosmetics.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductsOfTheWeek = _productRepository.ProductsOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
