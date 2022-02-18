using Microsoft.AspNetCore.Mvc;

namespace MVM.Controlles
{
    public class ContactPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
