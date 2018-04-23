using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallengeApr23;

namespace PalindromeTest
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void Basic()
        {
            string p1 = "racecar";

            bool expected = true;
            bool result = Palindrome.IsPalindrome(p1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Empty()
        {
            string p1 = "";

            bool expected = true;
            bool result = Palindrome.IsPalindrome(p1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Caps()
        {
            string p1 = "Racecar";

            bool expected = true;
            bool result = Palindrome.IsPalindrome(p1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CapsPunct()
        {
            string p1 = "never Odd, or Even.";

            bool expected = true;
            bool result = Palindrome.IsPalindrome(p1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Not()
        {
            string p1 = "this really isn't a palindrome";

            bool expected = false;
            bool result = Palindrome.IsPalindrome(p1);

            Assert.AreEqual(expected, result);
        }
    }
}
