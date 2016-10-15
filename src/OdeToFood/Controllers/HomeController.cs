using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _Restaurant;

        public HomeController(IRestaurantData Restaurent)
        {
            _Restaurant = Restaurent;
        }
        public IActionResult Index()
        {
            var model = _Restaurant.GetAll();
            //return Content("Hello from Home controller");
            return View(model);
        }
    }
}
