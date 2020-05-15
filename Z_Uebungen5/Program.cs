// a.voss@fh-aachen.de
//
// Gesammelte Übungen 0x04
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Z_Uebungen5
{
    class Program
    {
        static void Main(string[] args)
        {
            Elunore();
            Esari();
            Elfshys();
            Emberstorm();
            Ebonbrook();
        }

        static void Elunore()
        {
            Console.WriteLine("Elunore");
            
            Console.Write("01) MyReverse 'Hallo': ");
            foreach (char c in MyReverse("Hallo")) {
                Console.Write($"'{c}' ");
            }

            Console.WriteLine();
        }
        
        private static IEnumerable<char> MyReverse(string s) {
            for (int i = s.Length - 1; i >= 0; --i)
                yield return s[i];
        }
        
        static void Esari()
        {
            Console.WriteLine("Esari");

            Console.WriteLine($"01) Prims: {String.Join(',', Prims(19))}");
        }

        // nicht so effizient, aber verständlich (hoffe ich)
        private static IEnumerable<int> Prims(int max) {
            for (int n = 2; n <= max; ++n)
                if (Enumerable.Range(1, n).Where(i=>(n%i==0)).Select(n=>n).Count()==2)
                yield return n;
        }

        static void Elfshys()
        {
            Console.WriteLine("Elfshys");

            string s = "012mmmm7890mmm", p = "mm";

            var res1 = FindAll(s, p);
            Console.WriteLine($"01) pos: {string.Join(", ", res1)}");
        }

        // die alte Lösung ist auskommentiert, so dass man genau sieht, wo man
        // etwas anpassen muss
        
        // static List<int> FindAll(string s, string pattern)
        static IEnumerable<int> FindAll(string s, string pattern)
        {
            // var l = new List<int>();
            var len = pattern.Length;
            
            var i = 0;
            while (i+len <= s.Length)
            {
                if (s.Substring(i, len) == pattern)
                {
                    // l.Add(i);
                    yield return i;
                    i += len;
                }
                else
                {
                    ++i;
                }
            }

            //return l;
        }

        static void Emberstorm()
        {
            Console.WriteLine("Emberstorm");
            
            var rnd = new Random();

            // Zahlen 0..99
            var odd = Enumerable.Range(1, 20).Select(n => rnd.Next(100)).Where(n => n % 2 == 0);
            Console.WriteLine($"01) odd: {String.Join(",", odd)}");

            var groups5 =
                from n in Enumerable.Range(1, 20).Select(n => rnd.Next(100))
                group n by n % 5
                into g
                orderby g.Key
                select new {rem = g.Key, nums = g.Count()};

            Console.WriteLine($"02) n%5: {String.Join(",", groups5)}");
        }

        static void Ebonbrook() {
            Console.WriteLine("Ebonbrook");

            string[] lines = File.ReadAllLines("../../../simple.xml");
            //foreach (var line in lines) {
            //    Console.WriteLine("line " + line);
            //}

            // ein wenig spezifisch, mit XML-Strukturen ginge das besser
            var waffles = lines.Select(line => line.Split('<', '>'))
                .Where(s=>s.Length>3 && "/"+s[1]==s[^2] && s[2].Contains("Waffle"))
                .Select(s=>s[2]);
            Console.WriteLine("01) Waffles: " + String.Join(",", waffles));
        }

    }
}
