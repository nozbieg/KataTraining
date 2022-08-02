using System;
using System.Linq;

namespace KataTraining.LettersCounter
{
    public static class LettersCounterKata
    {
        public static Dictionary<char, int> CountLetters(string input)
        {


            var lettersDictionary = new Dictionary<char, int>();
            foreach (var letter in input.ToLower())
            {

                if (!lettersDictionary.ContainsKey(letter))
                {
                    lettersDictionary.Add(letter, 1);
                }
                else
                {
                    lettersDictionary[letter]++;
                }
            }

            return lettersDictionary;
        }
    }
}
