using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewSiteData.Base.Model;
using ReviewSiteLogic.Util;

namespace ReviewSiteTest {

    [TestClass]
    public class SerializationTest {

        private List<Restaurant> restaurants;
        private List<Review> reviews;

        [TestInitialize]
        public void Init() {
            //todo use DummyDataLoader to bring in data
        }

        [TestMethod]
        public void RestaurantSerialization() {
            Assert.Fail();
        }

        [TestMethod]
        public void ReviewSerialization() {
            Assert.Fail();
        }

    }

}