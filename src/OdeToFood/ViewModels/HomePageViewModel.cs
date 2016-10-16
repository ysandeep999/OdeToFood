using OdeToFood.Entities;
using System.Collections.Generic;

namespace OdeToFood.ViewModels
{
    public class HomePageViewModel
    {
        public string CurrentMessage { get; set; }
        //public int ID { get; set; }
        //public string Message { get; set; }

        public IEnumerable<Restaurant> Restaurants { get; set; }

    }
}
