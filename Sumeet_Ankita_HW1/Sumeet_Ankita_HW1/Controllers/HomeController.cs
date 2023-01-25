using Microsoft.AspNetCore.Mvc;

namespace Sumeet_Ankita_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Internships()
        {
            return View();
        }

        public IActionResult Clubs()
        {
            return View();
        }
        public IActionResult Personality()
        {
            return View();
        }

        public IActionResult Music()
        {
            return View();
        }
        public IActionResult Food()
        {
            return View();
        }

        //TODO: Create a new action method for the new page


        public FileResult Resume()
        {
            string path = _environment.WebRootPath + "/files/Resume22_AnkitaSumeet.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "Resume22_AnkitaSumeet.pdf");
        }
    }
}