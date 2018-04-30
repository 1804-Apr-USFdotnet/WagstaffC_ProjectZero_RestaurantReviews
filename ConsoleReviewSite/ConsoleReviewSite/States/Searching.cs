using System;
using System.Collections.Generic;

namespace ConsoleReviewSite.States {

    public class Searching : State {

        public Searching() {
            transitions = new Dictionary<char, StateId>() {
                {'q', StateId.Quit}
            };
        }

        public override State Enter() {
            Display();
            return new ViewingResults(UserSearchTerm());
        }

        private string UserSearchTerm() {
            Console.WriteLine("Enter Search Term: ");
            return Console.ReadLine();
        }

        public override void Display() {
            Console.WriteLine("Searching...");
        }

    }

}