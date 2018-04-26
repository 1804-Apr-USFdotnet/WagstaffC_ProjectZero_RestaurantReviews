using ReviewSiteData.Base.Model;
using Newtonsoft.Json;

namespace ReviewSiteLogic.Serialization {

    public static class RestaurantSerializer {

        public static string Serialize(this Restaurant restaurant) => JsonConvert.SerializeObject(restaurant);

    }

}