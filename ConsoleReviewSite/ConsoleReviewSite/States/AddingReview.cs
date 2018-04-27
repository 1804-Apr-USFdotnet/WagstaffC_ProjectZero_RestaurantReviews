using System;
using ReviewSiteLogic;

namespace ConsoleReviewSite.States {

    public class AddingReview : ViewingRestaurant {

        public AddingReview(Session s) : base(s) { }

        public void GetParams() { }

        public void Complete() { }

        public override void Display() {
            throw new NotImplementedException();
        }

    }

}