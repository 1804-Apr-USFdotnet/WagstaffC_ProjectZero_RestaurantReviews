using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeApr23
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            return Strip(str).Equals(Reverse(Strip(str)));
        }

        public static string Reverse(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }

        public static string Strip(string str)
        {
            string stripped = "";
            foreach (char part in str.ToCharArray())
            {
                if (Char.IsLetterOrDigit(part))
                {
                    stripped += part;
                }
            }
            return stripped.ToLower();
        }

    }
}
