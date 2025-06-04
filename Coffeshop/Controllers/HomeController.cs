using Microsoft.AspNetCore.Mvc;

namespace Coffeshop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
