using System;

namespace E_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dtdtdtdt0;
            DateTime dt0 = new DateTime(2013, 02, 18, 10, 15, 23);      // new instance
            DateTime dt1 = dt0.AddDays(2);

            // call a member function

            Console.WriteLine("dt0:   '" + dt0 + "'");
            Console.WriteLine("dt1:   '" + dt1 + "'");
            Console.WriteLine("day:   '" + dt1.DayOfWeek + "'");
            Console.WriteLine("day:   '" + dt1.ToUniversalTime() + "'");

            Random rand0 = new Random(-42);     // creates a new variable of type "Random" with seed
            Random rand1 = null;                // default init.

            Console.WriteLine("rand0   '" + rand0 + "'");
            Console.WriteLine("rand1   '" + rand1 + "'");

            Random rand = new Random();
            int n1 = rand.Next();               // non-negative
            int n2 = rand.Next(5);              // excl. upper bound
            int n3 = rand.Next(1, 4);           // incl. lower bound, excl. upper bound
            double f1 = rand.NextDouble();      // >=0.0 but <1.0

            Random rr = new Random();
            for (int k = 0; k < 10; ++k)
            {

                Console.WriteLine("rand_k   '" + rr.Next(1, 10) + "'");
            }
        }
    }
}