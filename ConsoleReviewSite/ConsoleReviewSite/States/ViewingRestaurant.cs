using ReviewSiteLogic;

namespace ConsoleReviewSite.States {

    public class ViewingRestaurant : State {

        private int restaurantId;

        public ViewingRestaurant(Session s) : base(s) { }

        public override void Display() {
            throw new System.NotImplementedException();
        }

    }

}