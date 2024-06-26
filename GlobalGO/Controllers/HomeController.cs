using Microsoft.AspNetCore.Mvc;

namespace GlobalGO.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult peruba()
        {
            return null;
        }

    }
}
