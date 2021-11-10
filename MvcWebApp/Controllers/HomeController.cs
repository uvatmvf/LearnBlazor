using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcWebApp.Models;
using System.Diagnostics;

namespace MvcWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Host() => View("_Host");

        public IActionResult Index()
        {
            return View(new PersonViewModel() { FirstName = "Frank" });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
