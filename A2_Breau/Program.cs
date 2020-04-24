using System;
using System.Linq;

namespace A2_Breau
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 1;
            var number2 = 2;
            Swap(ref number1, ref number2);
            Console.WriteLine($"a: '{number1}' b: '{number2}'");

            Fill(out var array);
            Console.WriteLine($"c: '{string.Join(',', array)}'");

            Console.WriteLine(Max(9, 3, 10, 50, 2));
        }

        private static void Swap(ref int x, ref int y)
        {
            var tmp = x;
            x = y;
            y = tmp;
        }

        private static void Fill(out int[] x)
        {
            x = new[] {new Random().Next(100), new Random().Next(100)};
        }

        private static int Max(params int[] x)
        {
            return x.Max();
            /*int max = x[0];
            foreach (var NUMBER in x)
            {
                if (NUMBER > max)
                {
                    max = NUMBER;
                }
            }
            return max*/
        }
    }
}