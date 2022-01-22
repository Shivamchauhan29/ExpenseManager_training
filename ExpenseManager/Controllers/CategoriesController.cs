using ExpenseManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManager.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            Category[] categories =
            {
                new Category{ 
                Id = 1,
                Title = "Clothing",
                Description = "Test Desc",
                CategoryType = CategoryType.Expense,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
                },
                new Category{
                Id = 2,
                Title = "Salary",
                Description = "Test Desc",
                CategoryType = CategoryType.Income,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
                },
                new Category{
                Id = 3,
                Title = "Food",
                Description = "Test Desc",
                CategoryType = CategoryType.Expense,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
                },
                new Category{
                Id = 4,
                Title = "Traveling",
                Description = "Test Desc",
                CategoryType = CategoryType.Expense,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
                }
            };  // Categories will be fetched from database in realtime 


            return View(categories);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
