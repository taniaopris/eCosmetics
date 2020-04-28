using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCosmetics.Models;
using eCosmetics.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eCosmetics.Controllers
{
    public class ProductsTableController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsTableController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [Authorize]
        public IActionResult Index()
        {
            if (User.Identity.Name != "admin@yahoo.com") return RedirectToAction("Index", "Home");

            IEnumerable<Product> products = _productRepository.AllProducts.OrderBy(p => p.ProductId);

            return View(new ProductsListViewModel
            {
                Products = products
            });
        }

        [Authorize]
        public RedirectToActionResult RemoveFromProductsTable(int productId)
        {
            if (User.Identity.Name != "admin@yahoo.com") return RedirectToAction("Index", "Home");

            var selectedProduct = _productRepository.AllProducts.FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _productRepository.DeleteProduct(selectedProduct);
            }
            return RedirectToAction("Index");
        }
    }
}
