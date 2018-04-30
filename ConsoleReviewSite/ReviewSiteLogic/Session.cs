using System;
using System.Collections.Generic;
using NLog;
using ReviewSiteData;
using ReviewSiteData.Persistence;
using ReviewSiteLogic.Render;
using ReviewSiteLogic.Util;

namespace ReviewSiteLogic {

    public class Session {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        private readonly WorkUnit _workUnit;
        private readonly DisplayConverter dsp;

        public Session(string name="ReviewSiteContext") {
            try {
                _workUnit = new WorkUnit(new ReviewSiteContext(name));
            }
            catch (Exception e) {
                logger.Fatal(e.Message);
            }

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

        public List<RestaurantDisplay> SearchRestaurants(string term) {
            var restaurants = _workUnit.Restaurants.SearchRestaurants(term);
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
            try {
                _workUnit.Reviews.Add(dsp.ToModel(rd, restId));
                _workUnit.SaveChanges();
            }
            catch (Exception e) {
                logger.Error(e.Message);
            }
        }

    }

}