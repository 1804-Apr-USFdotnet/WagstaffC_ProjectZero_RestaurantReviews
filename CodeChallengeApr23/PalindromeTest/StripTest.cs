using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallengeApr23;

namespace PalindromeTest
{
    [TestClass]
    public class StripTest
    {
        [TestMethod]
        public void Basic()
        {
            string initial = "asdf";
            string expected = "asdf";

            string result = Palindrome.Strip(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Empty()
        {
            string initial = "";
            string expected = "";

            string result = Palindrome.Strip(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Numbers()
        {
            string initial = "a3df4";
            string expected = "a3df4";

            string result = Palindrome.Strip(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Whitespace()
        {
            string initial = "a s d f";
            string expected = "asdf";

            string result = Palindrome.Strip(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Punctuation()
        {
            string initial = "a, s d.f3  ";
            string expected = "asdf3";

            string result = Palindrome.Strip(initial);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Caps()
        {
            string initial = "aSdF";
            string expected = "asdf";

            string result = Palindrome.Strip(initial);

            Assert.AreEqual(expected, result);
        }
    }
}
