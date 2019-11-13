using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>() {
               new Restaurant {Id=1, Name="Saeed's Pizza", Location="Amman", Cuisine=CuisineType.Italian},
               new Restaurant {Id=2, Name="Irbid's Pizza", Location="Irbid", Cuisine=CuisineType.Indian},
               new Restaurant {Id=3,Name="Karak's Pizza", Location="Karak", Cuisine=CuisineType.Mexican}
            };
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
