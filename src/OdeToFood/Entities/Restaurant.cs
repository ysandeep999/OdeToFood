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
        public string Name { get; set; }
        public int ID { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
