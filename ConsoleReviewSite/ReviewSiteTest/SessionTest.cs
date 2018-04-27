using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleReviewSite.Render;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewSiteLogic;

namespace ReviewSiteTest {

    [TestClass]
    public class SessionTest {

        private Session session;

        [TestInitialize]
        public void Init() {
            session = new Session("TestReviewSiteContext");
        }

        [TestMethod]
        public void ViewRestaurantDisplay() {
            var result = session.ViewRestaurant(2);

            Assert.IsInstanceOfType(result, typeof(RestaurantDisplay));
        }

        [TestMethod]
        public void ViewTopRestaurants() {
            var result = session.ViewTopRestaurants();

            Assert.IsInstanceOfType(result, typeof(List<RestaurantDisplay>));
        }

        [TestMethod]
        public void AddReview() {
            string reviewGuid = Guid.NewGuid().ToString();
            var rd = new ReviewDisplay("ReviewerName", "ReviewTitle", reviewGuid, 5, "");
            int restid = 1;

            session.AddReview(rd, restid);
            var result = session.ViewReviews(restid).Single(r => r.Body == reviewGuid);
            result.DatePublished = "";

            Assert.AreEqual(rd.ToString(), result.ToString());
        }
    }

}