using System;
using System.Collections.Generic;
using ReviewSiteData;
using ReviewSiteData.Base.Model;
using ReviewSiteData.Persistence;

namespace ReviewSiteLogic {

    public class Session {

        private WorkUnit _workUnit;

        public Session() {
            _workUnit = new WorkUnit(new ReviewSiteContext());
        }

        public List<Restaurant> ViewRestaurants() {
            throw new NotImplementedException();
        }

        public Restaurant ViewRestaurant() {
            throw new NotImplementedException();
        }

        public List<Review> ViewReviews(int id) {
            throw new NotImplementedException();
        }

    }

}