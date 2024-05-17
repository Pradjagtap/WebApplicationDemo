using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
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
            ViewData["message"] = "Welcome to asp.net core using mvc";

            List<string> cities = new List<string>()
            {
                "Pune", "Mumbai","Nagpur","Delhi"
            };

            ViewData["cities"] = cities;

            ViewBag.Msg = "This is an example of viewbag";
            ViewBag.Cities = cities;

            TempData["company"] = "Think Quotient";
            TempData.Keep("company"); // allows to hold data with multiple request
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {

            string name = TempData["company"].ToString();
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
