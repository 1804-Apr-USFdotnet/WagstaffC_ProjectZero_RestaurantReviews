using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewSiteLogic.Models;

namespace ReviewSiteTest
{
    [TestClass]
    public class RestaurantTest
    {
        Restaurant restaurant;
        Review review;
        List<Review> reviews;

        [TestInitialize]
        public void init()
        {
            restaurant = new Restaurant();
            reviews = new List<Review>();
            review = new Review("friend", "my favorite", "yes thanks", 4);

            reviews.Add(new Review("asdf", "bad", "burgers", 7));
            reviews.Add(new Review("fdsa", "good", "fries", 3));
            reviews.Add(new Review("dsaf", "v good", "yes", 10));
            reviews.Add(review);

            foreach (Review r in reviews)
            {
                restaurant.Reviews.Add(r);
            }
        }

        [TestMethod]
        public void AvgRating()
        {
            double expected = 6d;
            double result = restaurant.Rating();
            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReviewInOut()
        {
            string serialized = review.ToString();

            Review actual = new Review(serialized);
            
            Assert.AreEqual(review, actual);
        }
    }
}
