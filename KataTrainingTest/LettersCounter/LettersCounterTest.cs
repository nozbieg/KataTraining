using System;
using System.Linq;
using KataTraining.LettersCounter;

namespace KataTrainingTest.LettersCounter
{
    public class LettersCounterTest
    {

        [Fact]
        public void LettersCounter_Test()
        {
            var input = "Ala ma małego fajnego kota, a Adek ma na niego alergie";
            var funcResult = LettersCounterKata.CountLetters(input);
            funcResult['a'].Should().Be(11);
        }

    }
}
