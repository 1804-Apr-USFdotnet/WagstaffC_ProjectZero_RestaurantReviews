using System;
using System.Collections.Generic;
using ReviewSiteData;
using ReviewSiteData.Base.Model;
using ReviewSiteData.Persistence;
using ReviewSiteLogic.Render;
using ReviewSiteLogic.Util;

namespace ReviewSiteLogic {

    public class Session {

        private WorkUnit _workUnit;
        private DisplayConverter dsp;

        public Session(string name="ReviewSiteContext") {
            _workUnit = new WorkUnit(new ReviewSiteContext(name));
            dsp = new DisplayConverter();
        }

        public List<RestaurantDisplay> ViewTopRestaurants() {
            var topRestaurants = _workUnit.Restaurants.GetTopRestaurants(3);
            return dsp.ToDisplay(topRestaurants);
        }

        public List<RestaurantDisplay> ViewRestaurants() {
            var restaurants = _workUnit.Restaurants.GetRestaurantsReviews();
            return dsp.ToDisplay(restaurants);
        }

        public RestaurantDisplay ViewRestaurant(int id) {
            var restaurant = _workUnit.Restaurants.GetRestaurantReviews(id);
            return dsp.ToDisplay(restaurant);
        }

        public List<ReviewDisplay> ViewReviews(int id) {
            var reviews = _workUnit.Reviews.GetReviews(id);
            return dsp.ToDisplay(reviews);
        }

        public void AddReview(ReviewDisplay rd, int restId) {
            _workUnit.Reviews.Add(dsp.ToModel(rd, restId));
            _workUnit.SaveChanges();
        }

    }

}