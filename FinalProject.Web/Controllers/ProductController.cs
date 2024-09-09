using FinalProject.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new()
            {
                new Product {Id=1,Name="Noutbuk"},
                new Product {Id=2,Name="Cpu"},
                new Product {Id=3,Name="Ram"},
                new Product {Id=4,Name="Kuller fan"},
            };

            return View(products);
        }
    }
}
