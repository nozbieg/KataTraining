using System;
using System.Linq;

namespace KataTraining.CycleFinder
{
    public static class CylceFinderKata
    {
        public static bool DetectCycleInArray(int[] array)
        {
            int harePos = 0;
            for (int i = 0; i < array.Length; i++)
            {

                var tortoiseValue = array[i];

                if (harePos >= array.Length)
                {
                    harePos = harePos - array.Length;
                }
                var hareValue = array[harePos];
                harePos += 2;
                if (tortoiseValue == hareValue && i != 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}

