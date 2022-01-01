using Microsoft.AspNetCore.Mvc;

namespace MVM.Controlles
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Blogs()
        {
            return View();
        }
    }
}
