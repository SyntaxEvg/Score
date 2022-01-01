using Microsoft.AspNetCore.Mvc;

namespace MVM.Controlles
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
