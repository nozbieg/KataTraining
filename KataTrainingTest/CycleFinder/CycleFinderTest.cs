using System;
using System.Linq;
using KataTraining.CycleFinder;

namespace KataTrainingTest.CycleFinder
{
    public class CycleFinderTest
    {

        [Fact]
        public void CycleFinder_Success_Test()
        {
            var input = new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 };
            var funcResult = CylceFinderKata.DetectCycleInArray(input);

            funcResult.Should().BeTrue();

        }


        [Fact]
        public void CycleFinder_Fail_Test()
        {
            var input = new[] { 1, 2, 3, 4, 5 };
            var funcResult = CylceFinderKata.DetectCycleInArray(input);

            funcResult.Should().BeFalse();

        }

        [Theory]
        [InlineData(new[] { 9, 8, 7, 6, 1, 2, 3, 4, 9, 8, 7, 6 })]
        [InlineData(new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 })]
        [InlineData(new[] { 1, 75, 53, 2, 5, 1, 75, 53, 2, 5, 1, 12, 32, 1, 75, 53, 2, 1, 75, 53 })]
        [InlineData(new[] { 3, 2, 3, 3, 3, 3, 1, 2, 3, 1, 2, 3 })]
        [InlineData(new[] { 9, 8, 7, 6, 9, 8, 7, 6, 9, 8, 7, 6 })]
        public void CycleFinder_Theory_Test(int[] input)
        {
            var funcResult = CylceFinderKata.DetectCycleInArray(input);

            funcResult.Should().BeTrue();

        }
    }
}
