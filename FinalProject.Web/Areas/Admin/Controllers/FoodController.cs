using Business.Abstract;
using Business.Concrete;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FoodController : Controller
    {
        IFoodService _foodService = new FoodManager();
        IFoodCategoryService _foodCategoryService = new FoodCategoryManager();

        public IActionResult Index()
        {
            var data = _foodService.GetAll();

            return View(data);
        }

        public IActionResult Create()
        {
            ViewData["FoodCategories"] = _foodCategoryService.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Food food)
        {
            if (ModelState.IsValid)
            {
                _foodService.Add(food);

                return RedirectToAction("Index");
            }
            return View(food);
        }
    }
}
