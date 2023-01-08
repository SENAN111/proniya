using Microsoft.AspNetCore.Mvc;

namespace proniya.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart()
        { return View(); }
        public IActionResult Login()
        { return View(); }
        public IActionResult Shop()
        { return View(); }
        public IActionResult Singleproduct()
        { return View(); }
    }
}
