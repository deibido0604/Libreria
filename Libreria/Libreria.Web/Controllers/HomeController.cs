using Microsoft.AspNetCore.Mvc;

namespace Libreria.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
