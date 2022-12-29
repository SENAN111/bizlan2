using Microsoft.AspNetCore.Mvc;

namespace newbIZland.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
