using System.Collections.Generic;
using ConsoleReviewSite.Render;
using ReviewSiteData.Base.Model;

namespace ReviewSiteLogic.Util {

    public class DisplayConverter {

        public RestaurantDisplay ToDisplay(Restaurant r) {
            return new RestaurantDisplay();
        }

        public ReviewDisplay ToDisplay(Review r) {
            return new ReviewDisplay();
        }

        public List<RestaurantDisplay> ToDisplay(List<Restaurant> r) {
            return new List<RestaurantDisplay>();
        }

        public List<ReviewDisplay> ToDisplay(List<Review> r) {
            return new List<ReviewDisplay>();
        }

    }

}