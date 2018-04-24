using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewSiteLogic.Models;

namespace ReviewSiteTest {

    [TestClass]
    public class ReviewTest {

        Restaurant restaurant;
        Review review;
        List<Review> reviews;

        [TestInitialize]
        public void Init() {
            restaurant = new Restaurant();
            reviews = new List<Review>();
            review = new Review("friend", "my favorite", "yes thanks", 4);

            reviews.Add(new Review("asdf", "bad", "burgers", 7));
            reviews.Add(new Review("fdsa", "good", "fries", 3));
            reviews.Add(new Review("dsaf", "v good", "yes", 10));
            reviews.Add(review);

            foreach (var r in reviews) {
                restaurant.Reviews.Add(r);
            }
        }

        [TestMethod]
        public void ReviewInOut() {
            string serialized = review.ToString();

            Review actual = new Review(serialized);

            Assert.AreEqual(review, actual);
        }

    }

}