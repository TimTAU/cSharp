using System;
using System.Linq;

namespace A_Types_04_Anonymous {
    class Program {
        static void Main(string[] args) {
            // this is an anonymous class, containing two integers
            var p1 = new {x = 1, y = 2};
            var p2 = new {x = 3, y = 4};
            var pn = p1;
            Console.WriteLine($"01) pn.x={pn.x}, pn.y={pn.y}");
            pn = p2; // assigning is possible for equal types
            Console.WriteLine($"02) pn.x={pn.x}, pn.y={pn.y}");

            int n = 12;
            string s = "twelve";
            C c = new C();
            // now class/instance content is given by types and values of n and s
            var x = new {n, s, c};
            s = "123";
            c.n = 3;
            Console.WriteLine($"03) x.s={x.s}, x.n={x.n}, x.c.n={x.c.n}");

            // why anonymous types? first some LINQ
            int[] numbers = {5, 4, 1, 3};
            var numsx2 = from m in numbers select 2 * m;
            Console.Write("04) Numbers*2:");
            foreach (var i in numsx2)
                Console.Write(" " + i);
            Console.WriteLine();
            
            string[] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};
            var upperLowerWords =
                from w in words
                select new {Upper = w.ToUpper(), Lower = w.ToLower()};

            Console.WriteLine("05) upperLowerWords:");
            foreach (var ul in upperLowerWords) {
                Console.WriteLine($"      up: {ul.Upper}, lw: {ul.Lower}");
            }
        }

        class C {
            public int n = 1;
        }
    }
}