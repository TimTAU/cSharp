using System;
using System.Collections.Generic;
using System.Linq;

namespace A5_Elunore
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (char c in MyReverse("Hallo"))
            {
                Console.Write("c = " + c);
            }

            foreach (char c in MyReverse2("Hallo"))
            {
                Console.Write("c = " + c);
            }
        }

        //LINQ
        private static IEnumerable<char> MyReverse(string text)
        {
            return
                from c in text.ToCharArray().Reverse()
                select c;
        }

        //Yield
        private static IEnumerable<char> MyReverse2(string str)
        {
            var chars = str.ToCharArray().Reverse();
            foreach (var c in chars)
            {
                yield return c;
            }
        }
    }
}