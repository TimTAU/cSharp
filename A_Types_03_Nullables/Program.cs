using System;
using System.Collections.Generic;

namespace A_Types_03_Nullables {
    class Program {
        static void Main(string[] args) {
            int isnotnull = 0;          // can only hold an integer number, i.e.
            //int isnull = null;        // is not possible, but ...
            int? isnull = null;         // here it is; note the "?"

            Console.WriteLine("01) isnotnull=" + isnotnull);
            Console.WriteLine("02) isnull=" + isnull);
            isnull = 42;
            Console.WriteLine("03) isnull=" + isnull);

            int? x = null;
            // set y to the value of x if x is NOT null; otherwise, if x = null, set y to -1.
            int y = x ?? -1;
            Console.WriteLine("04) y=" + y);

            // often combined in this form:
            // o = getRandom(); if (o!=null) o.Next() ... else null
            var rnd = getRandom()?.Next() ?? 0;
            Console.WriteLine("05) rnd=" + rnd);

            // C# 8.0 NULL-Coalescing
            List<int> numbers = null;
            int? i = null;

            // assignment is only made if left (!) evaluation is null 
            // if (numbers==null) numbers=...
            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            Console.WriteLine("06) numbers.Count=" + numbers.Count +" "+i);
        }

        // statement body
        // static Random getRandom() {
        //      return new Random();
        // }

        // expression body
        static Random getRandom() => new Random();
    }
}