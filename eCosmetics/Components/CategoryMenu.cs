using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCosmetics.Models;
using eCosmetics.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCosmetics.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
