using Microsoft.AspNetCore.Mvc;

namespace MVM.Controlles
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
