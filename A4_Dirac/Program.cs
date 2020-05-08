using System;
using System.Collections.Generic;

namespace A4_Dirac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<f> list = new List<f>(new f[] {Math.Sin, Math.Cos, Math.Tan});
            Console.WriteLine("x \tsin(x) \tcos(x) \ttan(x)");
            for (double i = 0; i <= 2*Math.PI;)
            {
                Console.Write($"{i:0.00} \t");
                foreach (var function in list)
                {
                    Console.Write($"{function(i):0.00} \t");
                }
                Console.Write("\n");
                i += 0.1;
            }
        }

        delegate double f(double x);
    }
}