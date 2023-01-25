using Microsoft.AspNetCore.Mvc;

namespace Sumeet_Ankita_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}