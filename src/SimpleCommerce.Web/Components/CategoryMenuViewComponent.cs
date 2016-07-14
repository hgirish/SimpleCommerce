using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleCommerce.Core.Domain.Models;
using SimpleCommerce.Infrastructure.Domain.IRepositories;
using System.Linq;
using SimpleCommerce.Web.ViewModels.Catalog;

namespace SimpleCommerce.Web.Components
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryMenuViewComponent(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Query()
                .Where(x => !x.IsDeleted).ToList();

            var categoryMenuItems = new List<CategoryMenuItem>();

            foreach (var category in categories.Where(x=>!x.ParentId.HasValue))
            {
                var categoryMenuItem = Map(category);
                categoryMenuItems.Add(categoryMenuItem);
            }
            return View(categoryMenuItems);
        }

        private CategoryMenuItem Map(Category category)
        {
            var categoryMenuItem = new CategoryMenuItem
            {
                Id = category.Id,
                Name = category.Name,
                SeoTitle = category.SeoTitle
            };
            var childCategories = category.Child;
            foreach (var childCategory in childCategories)
            {
                var childCategoryMenuItem = Map(childCategory);
                childCategoryMenuItem.AddChildItem(childCategoryMenuItem);
            }
            return categoryMenuItem;
        }
    }
}