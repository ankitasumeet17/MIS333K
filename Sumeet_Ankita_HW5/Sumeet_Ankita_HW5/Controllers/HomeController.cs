using Microsoft.AspNetCore.Mvc;

namespace Sumeet_Ankita_HW5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}