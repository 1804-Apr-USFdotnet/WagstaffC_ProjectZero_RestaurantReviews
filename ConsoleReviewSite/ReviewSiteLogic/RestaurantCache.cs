using System.Collections.Generic;
using ReviewSiteLogic.Models;

namespace ReviewSiteLogic
{
    public class RestaurantCache
    {
        private static RestaurantCache cache = new RestaurantCache();
        private static List<Restaurant> restaurants;

        private RestaurantCache()
        {
            restaurants = new List<Restaurant>();
        }

    }
}
