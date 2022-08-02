using System;
using System.Linq;
using KataTraining.FizzBuzzKata;

namespace KataTrainingTest.FizzBuzz
{
    public class FizzBuzzTest
    {

        [Fact]
        public void FizzBuzz_Test_3()
        {
            var fizzbuzz = FizzBuzzTraining.GoFizzBuzz(3);
            fizzbuzz.Should().Be(FizzBuzzVal.FIZZ);
        }
        [Fact]
        public void FizzBuzz_Test_5()
        {
            var fizzbuzz = FizzBuzzTraining.GoFizzBuzz(5);
            fizzbuzz.Should().Be(FizzBuzzVal.BUZZ);
        }

        [Fact]
        public void FizzBuzz_Test_15()
        {
            var fizzbuzz = FizzBuzzTraining.GoFizzBuzz(15);
            fizzbuzz.Should().Be(FizzBuzzVal.FIZZBUZZ);
        }

    }
}
