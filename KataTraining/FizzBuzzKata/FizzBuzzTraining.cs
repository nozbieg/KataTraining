using System;
using System.Linq;

namespace KataTraining.FizzBuzzKata
{
    public static class FizzBuzzTraining
    {
        public static string GoFizzBuzz(int number)
        {
            var fizzBuzzStr = string.Empty;
            if (number % 3 == 0 && number % 5 == 0)
            {
                return FizzBuzzVal.FIZZBUZZ;
            }
            if (number % 3 == 0)
            {
                fizzBuzzStr += FizzBuzzVal.FIZZ;
            }
            if (number % 5 == 0)
            {
                fizzBuzzStr += FizzBuzzVal.BUZZ;
            }

            return fizzBuzzStr;
        }

        public static void FizzBuzzConsole(int min = 0, int max = 100)
        {

            Enumerable.Range(min, max).Select(x =>
            {
                var fizzBuzz = string.Empty;
                if (x % 3 == 0)
                {
                    fizzBuzz += FizzBuzzVal.FIZZ;
                }
                if (x % 5 == 0)
                {
                    fizzBuzz += FizzBuzzVal.BUZZ;
                }
                if (fizzBuzz == string.Empty)
                {
                    fizzBuzz = $" {x} ";
                }
                return fizzBuzz;
            }).ToList().ForEach(Console.WriteLine);
        }


    }
    public static class FizzBuzzVal
    {

        public const string FIZZ = "Fizz";
        public const string BUZZ = "Buzz";
        public const string FIZZBUZZ = "FizzBuzz";
    }
}
