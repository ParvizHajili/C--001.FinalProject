using Business.Abstract;
using Business.Concrete;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FoodCategoryController : Controller
    {
        IFoodCategoryService _foodCategoryService = new FoodCategoryManager();

        public IActionResult Index()
        {
            var data = _foodCategoryService.GetAll();

            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FoodCategory foodCategory)
        {
            if (ModelState.IsValid)
            {
                _foodCategoryService.Add(foodCategory);

                return RedirectToAction("Index");
            }

            return View(foodCategory);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _foodCategoryService.GetById(id);

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(FoodCategory foodCategory)
        {
            if (ModelState.IsValid)
            {
                _foodCategoryService.Update(foodCategory);

                return RedirectToAction("Index");
            }

            return View(foodCategory);
        }

        public IActionResult Delete(int id)
        {
            var data = _foodCategoryService.GetById(id);

            data.Deleted = id;

            _foodCategoryService.Update(data);

            return RedirectToAction("Index");
        }
    }
}
