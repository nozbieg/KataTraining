using System;
using System.Linq;

namespace KataTraining.WordFlipper
{
    public static class WordFlipperKata
    {
        public static string FlipWordSequence(string input)
        {

            return string.Join(' ', input.Split(' ').Where(x => !string.IsNullOrEmpty(x)).Reverse().ToArray());
        }
    }
}
