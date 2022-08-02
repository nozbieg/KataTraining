using System;
using System.Linq;

namespace KataTraining.CycleFinder
{
    public static class CylceFinderKata
    {
        public static bool DetectCycleInArray(int[] array)
        {
            int harePos = 1;
            for (int i = 0; i < array.Length; i++)
            {

                var tortoiseValue = array[i];

                if (harePos >= array.Length)
                {
                    harePos = harePos - array.Length;
                }
                var hareValue = array[i];
                harePos += 2;
                if (tortoiseValue == hareValue)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
