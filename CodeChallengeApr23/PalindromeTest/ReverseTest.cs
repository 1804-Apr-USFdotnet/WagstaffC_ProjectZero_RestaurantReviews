using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallengeApr23;

namespace PalindromeTest
{
    [TestClass]
    public class ReverseTest
    {
        [TestMethod]
        public void Basic()
        {
            string forward = "nonno";
            string backward = "onnon";

            string result = Palindrome.Reverse(forward);

            Assert.AreEqual(backward, result);
        }
    }
}
