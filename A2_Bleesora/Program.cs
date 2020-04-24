using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace A2_Bleesora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromCheck("Na, Freibierfan!"));
        }

        private static bool PalindromCheck(string text)
        {
            var ret = Regex.Replace(text, @"[^a-zA-Z]", "").ToLower();
            return ret.SequenceEqual(ret.Reverse());
        }
    }
}