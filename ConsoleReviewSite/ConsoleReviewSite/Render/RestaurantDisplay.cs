﻿using System.Collections.Generic;

namespace ConsoleReviewSite.Render {

    public class RestaurantDisplay {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Rating { get; set; }

        public List<ReviewDisplay> Reviews { get; set; }

        public RestaurantDisplay(int id, string name, string address, string phone, double rating) {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Rating = rating.ToString("N1");
        }

        public new string ToString() {
            return $"{Name}" + 
                   $"Rating: {Rating} / 10\n" + 
                   $"Address: {Address}\n" +
                   $"Phone: {Phone}\n";
        }
    }

}