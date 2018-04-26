using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ReviewSiteData.Base.Model;
using ReviewSiteData.Base.Repo;

namespace ReviewSiteData.Persistence.Repo {

    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository {

        public RestaurantRepository(DbContext context) : base(context) { }

        public ReviewSiteContext ReviewSiteContext => Context as ReviewSiteContext;

        public IEnumerable<Restaurant> GetTopRestaurants(int count) {
            return ReviewSiteContext.Restaurants.Include(rest => rest.Reviews)
                   .OrderByDescending(rest => rest.Reviews.Average(rev => rev.Rating)).Take(count).ToList();
        }

        public IEnumerable<Restaurant> GetRestaurantsReviews() {
            return ReviewSiteContext.Restaurants.Include(rest => rest.Reviews).ToList();
        }

        public IEnumerable<Restaurant> SearchRestaurants(string term) {
            throw new NotImplementedException();
        }
        
    }

}