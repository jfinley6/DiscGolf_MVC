using Microsoft.AspNetCore.Mvc;

namespace DiscGolfWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
