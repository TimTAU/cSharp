using System;
using System.Linq;

namespace A4_Dallaekur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(l1(1.78, 3.3, 2.234));
            Console.WriteLine(l2(1, 2, 3));
            Console.WriteLine(l2(2, 1, 3));
            Console.WriteLine(l22(1, 2, 3));
            Console.WriteLine(l22(2, 1, 3));
        }

        static double l1(double d1, double d2, double d3) => d1 + d2 + d3;

        static bool l2(int x, int a, int b) => Enumerable.Range(a, b).Contains(x);
        
        static bool l22(int x, int a, int b) => x >= a && x <= b;
    }
}