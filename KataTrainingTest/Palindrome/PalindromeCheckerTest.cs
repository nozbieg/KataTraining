using System;
using System.Linq;
using KataTraining.Palindrome;

namespace KataTrainingTest.Palindrome
{
    public class PalindromeCheckerTest
    {
        [Fact]
        public void BasicPalindromeSuccessTest()
        {
            var input = "kajak";
            var success = PalindromeChecker.CheckPalindrome(input);
            success.Should().Be(true);
        }

        [Fact]
        public void BasicPalindromeFailTest()
        {
            var input = "asdfghjiklkasd";
            var success = PalindromeChecker.CheckPalindrome(input);
            success.Should().Be(false);
        }


        [Theory]
        [InlineData("kajak")]
        [InlineData("ada")]
        [InlineData("123321")]

        public void PalindromeMulti_SuccessTest(string input)
        {

            var success = PalindromeChecker.CheckPalindrome(input);
            success.Should().Be(true);
        }
    }
}
