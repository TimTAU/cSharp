using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace A5_Emberstorm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            for (int i = 0; i < 21; i++)
            {
                numberList.Add(new Random().Next(100));
            }

            Console.WriteLine(String.Join(", ", Odd(numberList)));
            Console.WriteLine(String.Join(", ", Odd2(numberList)));

            OddGroup(numberList);
        }

        static IEnumerable<int> Odd(List<int> numberList)
        {
            return numberList.Where(i => i % 2 == 1);
        }

        static IEnumerable<int> Odd2(List<int> numberList)
        {
            return
                from i in numberList
                where i % 2 == 1
                select i;
        }

        static void OddGroup(List<int> numberList)
        {
            var x =
                from i in numberList
                where i % 2 == 1
                group i by i % 5
                into g
                select new {rem = g.Key, cnt = g.Count()};
            
            foreach (var g in x)
                Console.WriteLine("n%5={0}, cnt={1}", g.rem, g.cnt);
        }
    }
}