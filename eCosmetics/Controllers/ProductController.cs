using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCosmetics.Models;
using eCosmetics.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace eCosmetics.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

     
        public ViewResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "All products";
            }
            else
            {
                products = _productRepository.AllProducts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductsListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }

        [Authorize]
        public IActionResult Create()
        {
            if (User.Identity.Name != "admin@yahoo.com") return RedirectToAction("Index", "Home");
            
            return View(new CreateUpdateProductViewModel()
            {
                Product = new Product(),
                Categories = _categoryRepository.AllCategories.ToList()
            }); 
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(CreateUpdateProductViewModel createUpdateProductViewModel)
        {
            if (User.Identity.Name != "admin@yahoo.com") return RedirectToAction("Index", "Home");

            var categories = _categoryRepository.AllCategories.ToList();
            var selectedCategory = categories.FirstOrDefault(c => c.CategoryName == createUpdateProductViewModel.CategoryName);
            createUpdateProductViewModel.Product.CategoryId = selectedCategory.CategoryId;

            createUpdateProductViewModel.Product.ImageThumbnailUrl = createUpdateProductViewModel.Product.ImageUrl;
           
                _productRepository.CreateProduct(createUpdateProductViewModel.Product);

            return RedirectToAction("Index", "ProductsTable");
        }

        [Authorize]
        public IActionResult Update(int productId)
        {
            if (User.Identity.Name != "admin@yahoo.com") return RedirectToAction("Index", "Home");

            var product = _productRepository.GetProductById(productId);
            if (product == null)
                return NotFound();

            return View(new CreateUpdateProductViewModel()
            {
                Product = product,
                Categories = _categoryRepository.AllCategories.ToList()
            }); 
        }

        [Authorize]
        [HttpPost]
        public IActionResult Update(CreateUpdateProductViewModel createUpdateProductViewModel)
        {
            if (User.Identity.Name != "admin@yahoo.com") return RedirectToAction("Index", "Home");

            var categories = _categoryRepository.AllCategories.ToList();
            var selectedCategory = categories.FirstOrDefault(c => c.CategoryName == createUpdateProductViewModel.CategoryName);
            createUpdateProductViewModel.Product.CategoryId = selectedCategory.CategoryId;

            createUpdateProductViewModel.Product.ImageThumbnailUrl = createUpdateProductViewModel.Product.ImageUrl;

            _productRepository.UpdateProduct(createUpdateProductViewModel.Product);

            return RedirectToAction("Index", "ProductsTable");
        }
    }
}
