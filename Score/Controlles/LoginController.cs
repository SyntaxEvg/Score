using Microsoft.AspNetCore.Mvc;

namespace MVM.Controlles
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
