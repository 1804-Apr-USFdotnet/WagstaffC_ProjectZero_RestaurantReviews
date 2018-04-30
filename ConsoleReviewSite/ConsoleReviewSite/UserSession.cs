using ConsoleReviewSite.States;

namespace ConsoleReviewSite {

    public class UserSession {

        public State state;

        public UserSession() {
            state = new Home();
        }

        public void Go() {
            while (true) {
                state = state.Enter();
            }
        }

    }

}