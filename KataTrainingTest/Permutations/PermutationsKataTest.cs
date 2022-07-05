using System;
using System.Linq;

namespace KataTrainingTest.Permutations
{
    public class PermutationsKataTest
    {
        [Fact]
        public void Example1()
        {
            var testList = new List<string> { "a" };
            testList.Should().Equal(PermutationsKata.SinglePermutations("a").OrderBy(x => x).ToList());
        }

        [Fact]
        public void Example2()
        {
            var testList = new List<string> { "ab", "ba" };
            testList.Should().Equal(PermutationsKata.SinglePermutations("ab").OrderBy(x => x).ToList());
        }

        [Fact]
        public void Example3()
        {
            var testList = new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" };
            testList.Should().Equal(PermutationsKata.SinglePermutations("aabb").OrderBy(x => x).ToList());
        }
    }
}
