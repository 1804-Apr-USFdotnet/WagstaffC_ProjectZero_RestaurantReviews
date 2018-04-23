using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace ReviewSiteLogic.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public Restaurant()
        {
            Reviews = new List<Review>();
        }

        public Restaurant(Restaurant othRestaurant)
        {
            Id = othRestaurant.Id;
            Name = othRestaurant.Name;
            Address = othRestaurant.Address;
            Phone = othRestaurant.Phone;
            Reviews = new List<Review>(othRestaurant.Reviews);
        }

        public Restaurant(string json) : this(JsonConvert.DeserializeObject<Restaurant>(json)) { }

        public double Rating()
        {
            var ratings = from r in Reviews
                    select r.Rating;
            return ratings.Average();
        }

        public new string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
