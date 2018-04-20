using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewSiteData.Base.Model;

namespace ReviewSiteData.Base.Repo
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        IEnumerable<Restaurant> GetTopRestaurants(int count);
    }
}
