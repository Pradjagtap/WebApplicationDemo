using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Page1()
        {
            List<string> cities = new List<string>()
            {
                "Pune", "Mumbai","Nagpur","Delhi"
            };

            ViewData["cities"] = new SelectList(cities); // iterate the elements & single selection

            ViewData["city"] = new MultiSelectList(cities); // iterate the elemetns & allow multiple selection
            return View();

        }
    }
}
