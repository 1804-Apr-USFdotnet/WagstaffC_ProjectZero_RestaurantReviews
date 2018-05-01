using System;
using System.Collections.Generic;
using System.Linq;
using ReviewSiteLogic.Render;

namespace ConsoleReviewSite.States {

    public class ViewingResults : State {
        private enum SortType {
            NameAsc,
            NameDesc,
            RatingAsc,
            RatingDesc
        };

        private List<RestaurantDisplay> results;
        private Dictionary<char, SortType> sorts;
        private string searchTerm;

        public ViewingResults() {
            searchTerm = "";
            transitions = new Dictionary<char, StateId>() {
                {'1', StateId.ViewingRestaurant},
                {'2', StateId.Home},
                {'q', StateId.Quit}
            };

            sorts = new Dictionary<char, SortType>() {
                {'3', SortType.NameAsc},
                {'4', SortType.NameDesc},
                {'5', SortType.RatingDesc},
                {'6', SortType.RatingAsc}
            };
        }

        public ViewingResults(string searchTerm) : this() {
            results = _session.SearchRestaurants(searchTerm);
            this.searchTerm = searchTerm;
        }

        private ViewingResults(string searchTerm, SortType sort) : this() {
            this.searchTerm = searchTerm;
            switch (sort) {
                case SortType.NameAsc:
                    results = _session.SearchRestaurants(searchTerm).OrderBy(r => r.Name).ToList();
                    break;
                case SortType.NameDesc:
                    results = _session.SearchRestaurants(searchTerm).OrderByDescending(r => r.Name).ToList();
                    break;
                case SortType.RatingAsc:
                    results = _session.SearchRestaurants(searchTerm).OrderBy(r => r.Rating).ToList();
                    break;
                case SortType.RatingDesc:
                    results = _session.SearchRestaurants(searchTerm).OrderByDescending(r => r.Rating).ToList();
                    break;
            }
        }


        public override State Enter() {
            Display();

            var repsonse = WaitForInput();

            if (sorts.ContainsKey(repsonse)) return new ViewingResults(searchTerm, sorts[repsonse]);

            switch (transitions[repsonse]) {
                case StateId.ViewingRestaurant:
                    return new ViewingRestaurant(GetRestId());
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

        private int GetRestId() {
            Console.WriteLine("Enter the Restaurant's ID:");
            int result;
            Int32.TryParse(Console.ReadLine(), out result);
            return result;
        }

        public override void Display() {
            Console.WriteLine("Viewing Results...");

            if (results is null) results = _session.ViewRestaurants();

            if (results.Count > 0)
                foreach (var result in results)
                    Console.WriteLine(result);
            else
                Console.WriteLine("Search returned no results...");

            Console.WriteLine("(1) Select Restaurant\n" +
                              "(2) Home\n" +
                              "(3) Sort By Name A-Z\n" +
                              "(4) Sort By Name Z-A\n" +
                              "(5) Sort By Rating High-Low\n" +
                              "(6) Sort By Rating Low-High\n" +
                              "(q) Quit\n");
        }
    }

}