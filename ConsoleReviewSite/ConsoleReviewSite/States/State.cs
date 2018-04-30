using System;
using System.Collections.Generic;
using ReviewSiteLogic;

namespace ConsoleReviewSite.States {

    internal enum StateId { AddingReview, Home, Searching, ViewingRestaurant, ViewingResults, Quit };

    public abstract class State {

        protected static Session _session;
        internal Dictionary<char, StateId> transitions;
        internal StateId stateType;

        protected State() {
            _session = new Session("TestReviewSiteContext");
        }

        public abstract State Enter();

        public abstract void Display();

        protected char WaitForInput() {
            return Console.ReadKey(true).KeyChar;
        }

    }

}