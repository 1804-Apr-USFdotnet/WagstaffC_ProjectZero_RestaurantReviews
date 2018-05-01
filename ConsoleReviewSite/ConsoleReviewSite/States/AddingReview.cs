using System;
using ReviewSiteLogic.Render;

namespace ConsoleReviewSite.States {

    public class AddingReview : ViewingRestaurant {

        public AddingReview(int id) : base(id) { }

        public override State Enter() {
            Display();

            _session.AddReview(GetUserInput(), restaurantId);

            return new ViewingRestaurant(restaurantId);
        }

        private ReviewDisplay GetUserInput() {
            string name, title, body;
            int rating;

            Console.WriteLine("Enter Your Name (Optional):");
            name = Console.ReadLine();

            Console.WriteLine("Review Title:");
            title = Console.ReadLine();

            Console.WriteLine("Review Text (Optional):");
            body = Console.ReadLine();

            Console.WriteLine("Enter Your Rating 1-10:");
            Int32.TryParse(Console.ReadLine(), out rating);

            return new ReviewDisplay(name, title, body, rating, "");
        }

        public override void Display() {
            Console.WriteLine("Adding Review...");
            var name = _session.ViewRestaurant(restaurantId).Name;

            Console.WriteLine($"For {name}\n");
        }

    }

}