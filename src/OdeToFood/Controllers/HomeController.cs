using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Models.Home.Restaurant { Name = "Godavari", ID = 1};
            //return Content("Hello from Home controller");
            return View(model);
        }
    }
}
