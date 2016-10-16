using Microsoft.AspNetCore.Mvc;
using OdeToFood.Entities;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private string _greeter;
        private IRestaurantData _Restaurant;

        public HomeController(IRestaurantData Restaurent, IGreeter Greeter)
        {
            _Restaurant = Restaurent;
            _greeter = Greeter.GetGreeting();
        }
        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = _Restaurant.GetAll();
            model.CurrentMessage = _greeter;
            //return Content("Hello from Home controller");
            return View(model);
        }
    }
}
