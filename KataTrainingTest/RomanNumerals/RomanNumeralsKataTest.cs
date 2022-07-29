using System;
using System.Linq;
using KataTraining.RomanNumerals;

namespace KataTrainingTest.RomanNumerals
{
    public class RomanNumeralsKataTest
    {
        [Fact]
        public void TestToRoman_001()
        {
            int input = 1;
            string expected = "I";

            string actual = RomanNumeralsKata.ToRoman(input);

            actual.Should().Be(expected);
        }

        [Fact]
        public void TestToRoman_002()
        {
            int input = 2;
            string expected = "II";

            string actual = RomanNumeralsKata.ToRoman(input);

            actual.Should().Be(expected);
        }

        [Fact]
        public void TestFromRoman_001()
        {
            string input = "I";
            int expected = 1;

            int actual = RomanNumeralsKata.FromRoman(input);

            actual.Should().Be(expected);
        }

        [Fact]
        public void TestFromRoman_002()
        {
            string input = "II";
            int expected = 2;

            int actual = RomanNumeralsKata.FromRoman(input);

            actual.Should().Be(expected);
        }

        [Fact]
        public void TestFromRoman_4524()
        {
            string input = "MMMMDXXII";
            int expected = 4522;

            int actual = RomanNumeralsKata.FromRoman(input);

            actual.Should().Be(expected);
        }
        [Fact]
        public void TestFromRoman_666()
        {
            string input = "DCLXVI";
            int expected = 666;

            int actual = RomanNumeralsKata.FromRoman(input);

            actual.Should().Be(expected);
        }
        [Fact]
        public void TestFromRoman_444()
        {
            string input = "CDXLIV";
            int expected = 444;

            int actual = RomanNumeralsKata.FromRoman(input);

            actual.Should().Be(expected);
        }
        [Fact]
        public void TestToRoman_4524()
        {
            int input = 4522;
            string expected = "MMMMDXXII";

            string actual = RomanNumeralsKata.ToRoman(input);

            actual.Should().Be(expected);
        }
        [Fact]
        public void TestToRoman_666()
        {
            int input = 666;
            string expected = "DCLXVI";

            string actual = RomanNumeralsKata.ToRoman(input);

            actual.Should().Be(expected);
        }
        [Fact]
        public void TestToRoman_444()
        {
            int input = 444;
            string expected = "CDXLIV";

            string actual = RomanNumeralsKata.ToRoman(input);

            actual.Should().Be(expected);
        }
    }
}
