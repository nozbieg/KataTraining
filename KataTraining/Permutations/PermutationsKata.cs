using System;
using System.Linq;

namespace KataTraining.Permutations
{
    public static class PermutationsKata
    {

        public static List<string> SinglePermutations(string s)
        {
            char[] charArry = s.ToCharArray();
            var perm = new Permutation();
            perm.Permute(charArry, 0, s.Length - 1);
            return perm.PermuteList.Distinct().ToList();
        }
    }
    public class Permutation
    {
        public List<string> PermuteList = new List<string>();
        public void Permute(char[] arry, int i, int n)
        {
            int j;
            if (i == n)
            {
                Console.WriteLine(arry);
                PermuteList.Add(new string(arry));
            }
            else
            {
                for (j = i; j <= n; j++)
                {
                    Swap(ref arry[i], ref arry[j]);
                    Permute(arry, i + 1, n);
                    Swap(ref arry[i], ref arry[j]); //backtrack
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
    }
}
