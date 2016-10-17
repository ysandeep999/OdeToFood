using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Entities
{

    public enum CuisineType
    {
        none,
        Italian,
        French,
        American
    }
    public class Restaurant
    {
        [Display(Name="Restaurant Name")]
        [Required, MaxLength(40)]
        //[DataType(DataType.Password)]
        public string Name { get; set; }
        public int ID { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
