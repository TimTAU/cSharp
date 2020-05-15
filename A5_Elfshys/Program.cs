using System;
using System.Collections.Generic;

namespace A5_Elfshys
{
    class Program
    {
        static void Main(string[] args)
        {
            const string s = "012mmmm7890mmm", p = "mm";
            foreach (int n in FindAll(s, p))
                Console.WriteLine(n);
        }

        private static IEnumerable<int> FindAll(string text, string muster)
        {
            for (int i = 0;; i += muster.Length)
            {
                i = text.IndexOf(muster, i);
                if (i == -1)
                {
                    break;
                }

                yield return i;
            }
        }
    }
}