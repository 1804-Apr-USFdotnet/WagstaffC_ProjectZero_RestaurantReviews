using System.Collections.Generic;

namespace ReviewSiteData.Base.Model {

    public class Restaurant {

        public Restaurant() {
            Reviews = new List<Review>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }

}