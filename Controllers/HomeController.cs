using System.Diagnostics;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string first, last, email;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["FirstName"] = first;
            ViewData["LastName"] = last;
            ViewData["email"] = email;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
