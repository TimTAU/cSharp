using System;
using System.Collections.Generic;

namespace A2_Basinham
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', FindAll("babahaujsfashdbfvbafsjhabfb", "ba")));
        }

        private static int[] FindAll(string text, string muster)
        {
            List<int> indexList = new List<int>();
            for (int i = 0;; i += muster.Length)
            {
                i = text.IndexOf(muster, i);
                if (i == -1)
                {
                    return indexList.ToArray();
                }

                indexList.Add(i);
            }
        }
    }
}