using System;

namespace A1_Agroisil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random random = new Random();
            int[] ints = new int[10];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(1, 10);
            }
            Array.ForEach(ints, Console.WriteLine);
            Console.WriteLine("-----");
            foreach (var number in ints)
            {
                Console.WriteLine($"{number}");
            }

            
        }
    }
}