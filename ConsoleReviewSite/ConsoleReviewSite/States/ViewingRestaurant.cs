using System;
using System.Collections.Generic;
using ReviewSiteLogic;

namespace ConsoleReviewSite.States {

    public class ViewingRestaurant : State {

        public int restaurantId { get; set; }

        public ViewingRestaurant() {
            transitions = new Dictionary<char, StateId>() {
                {'1', StateId.AddingReview},
                {'2', StateId.Searching},
                {'3', StateId.Home},
                {'q', StateId.Quit}
            };
        }

        public ViewingRestaurant(int id) : this() {
            restaurantId = id;
        }

        public override State Enter() {
            Display();

            char response = WaitForInput();

            switch (transitions[response]) {
                case StateId.Searching:
                    return new Searching();
                case StateId.ViewingResults:
                    return new ViewingResults();
                case StateId.AddingReview:
                    return new AddingReview(restaurantId);
                case StateId.Home:
                    return new Home();
                case StateId.Quit:
                    Environment.Exit(0);
                    break;
                default:
                    return new Home();
            }

            return null;
        }

        public override void Display() {
            Console.WriteLine("Viewing Restaurant...");

            var restaurant = _session.ViewRestaurant(restaurantId);
            Console.WriteLine(restaurant);
            foreach (var review in restaurant.Reviews) {
                Console.WriteLine(review);
            }

            Console.WriteLine("(1) Add a Review\n" +
                              "(2) Search \n" +
                              "(3) Home\n" +
                              "(q) Quit");
        }

    }

}