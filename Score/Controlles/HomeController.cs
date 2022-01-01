using Microsoft.AspNetCore.Mvc;
using MVM.Model;

namespace MVM.Controlles
{
    public class HomeController : Controller
    {
       

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
