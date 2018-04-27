
using System;
using System.Collections.Generic;
using System.Configuration;
using ReviewSiteData.Base.Model;

namespace ReviewSiteTest.Util {

    public class DummyDataLoader {

        public DummyDataLoader(string path) {
            //ConfigurationManager.AppSettings.Get("testDataFiles")
        }

        public void Populate(out List<Restaurant> list) {
            throw new NotImplementedException();
        }

        public void Populate(out List<Review> list) {
            throw new NotImplementedException();
        }

    }

}