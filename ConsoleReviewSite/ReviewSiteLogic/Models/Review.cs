//todo deprecate

using System;
using Newtonsoft.Json;

namespace ReviewSiteLogic.Models {

    public class Review {

        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Rating { get; set; }
        public DateTime DatePublished { get; set; }

        public Review() { }

        public Review(string name, string title, string body, int rating) {
            Name = name;
            Title = title;
            Body = body;
            Rating = rating;
            DatePublished = DateTime.Now;
        }

        public Review(Review othReview) {
            this.Id = othReview.Id;
            this.RestaurantId = othReview.RestaurantId;
            this.Name = othReview.Name;
            this.Title = othReview.Title;
            this.Body = othReview.Body;
            this.Rating = othReview.Rating;
            this.DatePublished = othReview.DatePublished;
        }

        public Review(string json) : this(JsonConvert.DeserializeObject<Review>(json)) { }

        public new string ToString() => JsonConvert.SerializeObject(this);

    }

}