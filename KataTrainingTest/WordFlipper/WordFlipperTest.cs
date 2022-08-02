using System;
using System.Linq;
using KataTraining.WordFlipper;

namespace KataTrainingTest.WordFlipper
{
    public class WordFlipperTest
    {

        [Fact]
        public void WordFlipper_Success_Test()
        {
            var input = "jeden dwa trzy cztery";

            var funcResult = WordFlipperKata.FlipWordSequence(input);

            var output = "cztery trzy dwa jeden";

            funcResult.Should().Be(output);

        }
    }
}
