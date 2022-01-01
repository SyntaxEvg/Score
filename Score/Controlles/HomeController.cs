using Microsoft.AspNetCore.Mvc;
using MVM.Model;
using Score.Services.Interface;
using WebStore.ViewModels;

namespace MVM.Controlles
{
    public class HomeController : Controller
    {

        public IActionResult Index([FromServices] IProductData ProductData)
        {
            var products = ProductData.GetProducts()
                   .OrderBy(p => p.Order)
                   .Take(6)
                   .Select(p => new ProductViewModel
                   {
                       Id = p.id,
                       Name = p.Name,
                       Price = p.Price,
                       ImageUrl = p.ImageUrl,
                   });
            ViewBag.Products = products;

            //ControllerContext.HttpContext.Request.RouteValues

            //return Content("Данные из первого контроллера");
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public  IActionResult NotFounds()
        {
            return View();
        }

    }
}
