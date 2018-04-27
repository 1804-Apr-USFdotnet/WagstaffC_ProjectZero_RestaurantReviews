using System;
using System.Collections.Generic;
using ReviewSiteLogic;

namespace ConsoleReviewSite.States {

    public abstract class State {

        private static Session _session;
        protected List<State> transitions;

        protected State(Session s) {
            _session = s;
        }

        public abstract void Display();

        public char WaitForInput() {
            return Console.ReadKey(true).KeyChar;
        }

    }

}