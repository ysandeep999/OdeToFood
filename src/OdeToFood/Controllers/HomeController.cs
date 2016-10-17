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

        public IActionResult Details(int id)
        {
            var model = _Restaurant.Get(id);

            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);        
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newRestaurant = new Restaurant();
                newRestaurant.Name = model.Name;
                newRestaurant.Cuisine = model.Cuisine;

                newRestaurant = _Restaurant.add(newRestaurant);
                return RedirectToAction("Details", new { id = newRestaurant.ID });
            }
            else
            {
                return View();
            }

            
            //return View("Details", newRestaurant);
        }
    }
}
