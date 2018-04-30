using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ReviewSiteLogic;

namespace ConsoleReviewSite.States {

    public class Home : State {

        public Home() {
            transitions = new Dictionary<char, StateId>() {
                {'1', StateId.ViewingRestaurant},
                {'2', StateId.Searching},
                {'3', StateId.ViewingResults},
                {'q', StateId.Quit}
            };
        }

        public override State Enter() {
            Display();

            char response = WaitForInput();

            switch (transitions[response]) {
                    case StateId.ViewingRestaurant:
                        return new ViewingRestaurant(GetRestId());
                    case StateId.Searching:
                        return new Searching();
                    case StateId.ViewingResults:
                        return new ViewingResults();
                    case StateId.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        return new Home();
            }

            return null;
        }

        private int GetRestId() {
            Console.WriteLine("Enter the Restaurant's ID:");
            int result;
            Int32.TryParse(Console.ReadLine(), out result);
            return result;
        }

        public override void Display() {
            Console.WriteLine("Home...");

            Console.WriteLine("Top Rated Restaurants");
            var topRestaurants = _session.ViewTopRestaurants();
            foreach (var restaurant in topRestaurants) {
                Console.WriteLine(restaurant);
            }
            
            Console.WriteLine("(1) Select Restaurant\n" +
                              "(2) Search\n" +
                              "(3) View Full Listings\n" +
                              "(q) Quit\n");
        }

    }

}