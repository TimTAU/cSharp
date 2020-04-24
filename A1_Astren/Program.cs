using System;

namespace A1_Astren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Potenz(5,5));
        }

        static double Potenz(int b, int n)
        {
            return Math.Pow(b, n);
        }
    }
}