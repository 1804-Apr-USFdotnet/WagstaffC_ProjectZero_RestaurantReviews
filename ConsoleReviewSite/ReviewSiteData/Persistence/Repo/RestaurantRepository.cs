using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ReviewSiteData.Base.Model;
using ReviewSiteData.Base.Repo;

namespace ReviewSiteData.Persistence.Repo
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Restaurant> GetTopRestaurants(int count)
        {
            throw new NotImplementedException();
        }

        public ReviewSiteContext ReviewSiteContext
        {
            get => Context as ReviewSiteContext;
        }
    }
}
