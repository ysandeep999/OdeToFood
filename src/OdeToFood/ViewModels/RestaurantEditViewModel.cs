using OdeToFood.Entities;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(40)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
