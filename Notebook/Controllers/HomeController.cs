using Microsoft.AspNetCore.Mvc;

namespace Notebook.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
