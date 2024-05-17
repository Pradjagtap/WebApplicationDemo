using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeDetails()
        {
            List<string> cities = new List<string>()
            {
                "Pune", "Mumbai","Nagpur","Delhi"
            };

            ViewData["cities"] = new SelectList(cities);

            List<string> depart = new List<string>()
            {
                "IT","Computer","HR","Sales"
            };
            ViewData["depart"] = new SelectList(depart);
            return View();

        }
        [HttpPost]
        public IActionResult EmployeeDetails(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Gender = form["gender"];
            ViewBag.Email = form["email"];
            ViewBag.City = form["cities"];
            ViewBag.Dept = form["depart"];
            ViewBag.Qual = form["Qualification"];
            return View("Display");
        }
    }
}
