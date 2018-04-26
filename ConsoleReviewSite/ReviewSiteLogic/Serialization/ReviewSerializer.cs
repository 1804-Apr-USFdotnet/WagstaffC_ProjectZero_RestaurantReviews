using Newtonsoft.Json;
using ReviewSiteData.Base.Model;

namespace ReviewSiteLogic.Serialization {

    public static class ReviewSerializer {

        public static string Serialize(this Review review) => JsonConvert.SerializeObject(review);

    }

}