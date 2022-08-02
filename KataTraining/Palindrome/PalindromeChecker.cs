using System;
using System.Linq;

namespace KataTraining.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CheckPalindrome(string input)
        {
            var output = new string(input.ToCharArray().Reverse().ToArray());

            if (input == output)
            {
                return true;
            }
            return false;

        }
    }
}
