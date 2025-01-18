using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class CategoryController : Controller
    {
        private static List<Category> _categories = new List<Category>
        {
            new Category(1, "Laptop"),
            new Category(2, "Smart Phone"),
            new Category(3, "Printer"),
        };
        public IActionResult Index()
        {
            return View(_categories);
        }

        private Category FindCategoryById(int Id)
        {
            Category category = _categories.Find(category => category.Id == Id);
            if (category != null)
            {
                return category;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        [HttpPost]
        public IActionResult AddCategory(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
            {
                ModelState.AddModelError("", "Category name cannot be empty.");
                return RedirectToAction("Index");
            }

            int lastId = _categories.Count > 0 ? _categories.Max(c => c.Id) + 1 : 0;

            Category newCategory = new Category(lastId, categoryName);
            _categories.Add(newCategory);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteCategory(int categoryId)
        {
            Category category = FindCategoryById(categoryId);
            _categories.Remove(category);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditCategory(Category newCategory)
        {
            Category category = FindCategoryById(newCategory.Id);
            category.Name = newCategory.Name;
            return RedirectToAction("Index");
        }
    }
}
