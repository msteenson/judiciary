using judiciary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace judiciary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Guidance()
        {
            return View();
        }

        public IActionResult Publications()
        {
            return View();
        }

        public IActionResult Judgments()
        {
            return View();
        }

        public IActionResult PracticeDirections()
        {
            return View();
        }
        public IActionResult Sentencing()
        {
            return View();
        }
        public IActionResult Legislation()
        {
            return View();
        }
        public IActionResult Benchbooks()
        {
            return View();
        }
        public IActionResult Training()
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