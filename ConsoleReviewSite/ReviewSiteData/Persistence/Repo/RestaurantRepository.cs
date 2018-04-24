using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ReviewSiteData.Base.Model;
using ReviewSiteData.Base.Repo;

namespace ReviewSiteData.Persistence.Repo {

    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository {

        public RestaurantRepository(DbContext context) : base(context) { }

        public ReviewSiteContext ReviewSiteContext {
            get => Context as ReviewSiteContext;
        }

        public IEnumerable<Restaurant> GetTopRestaurants(int count) {
            throw new NotImplementedException();
        }

    }

}