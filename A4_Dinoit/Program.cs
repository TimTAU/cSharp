using System;

namespace A4_Dinoit
{
    class Program
    {
        static void Main(string[] args)
        {
            f add = (x, y) => x + y;
            f add2 = Add;
            Console.WriteLine(add(3, 2));
            Console.WriteLine(add2(3, 2));

            f mult = (x, y) => x * y;
            f mult2 = Mult;
            Console.WriteLine(mult(3, 2));
            Console.WriteLine(mult2(3, 2));
        }

        delegate int f(int x, int y);

        private static int Add(int x, int y)
        {
            return x + y;
        }
        
        private static int Mult(int x, int y)
        {
            return x * y;
        }
    }
}