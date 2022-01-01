using Microsoft.AspNetCore.Mvc;

namespace MVM.Controlles
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
