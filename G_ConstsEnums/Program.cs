using System;

namespace G_ConstsEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant floating point
            const double d = -1e-12;
            Console.WriteLine("double '" + d + "'");

            // constants according to type accuracy
            double dMin = double.MinValue;
            double dMax = double.MaxValue;
            double dEps = double.Epsilon;
            double dInf = double.PositiveInfinity;
            double dNaN = double.NaN;

            Console.WriteLine("double.MinValue:  " + dMin);
            Console.WriteLine("double.MaxValue:  " + dMax);
            Console.WriteLine("double.Epsilon:   " + dEps);
            Console.WriteLine("double.Pos.Inf.:  " + dInf);
            Console.WriteLine("double.NaN:       " + dNaN);

            // enums

            Cards q = Cards.Queen;
            Console.WriteLine("card queen: " + q + " int: " + (int)q);

            // "foreach" see later
            foreach (Cards c in Enum.GetValues(typeof(Cards)))
            //foreach (Cards c in Cards)
            {
                Console.WriteLine("card c:  " + c + " int: " + (int)c);
            }

            // casts an integer to a card
            Cards x = (Cards)9;
            Console.WriteLine("card x: " + x + " int: " + (int)x);

            // again, but there is no card with id 1 ...
            Cards y = (Cards)1000;
            Console.WriteLine("card y: " + y + " int: " + (int)y);

            // enumes are best suited for switch (switch see later)
            switch (y)
            {
                case Cards.As:
                    Console.WriteLine("As");
                    break;
                default:
                    Console.WriteLine("no As");
                    break;
            }

            Cards nAss = (Cards)100; // ex 
            Console.WriteLine("card y: " + nAss + " int: " + (int)nAss);
            int nAs = (int)Cards.As;
            Console.WriteLine("card As: " + nAs);
        }

        /// <summary>
        /// a sample enum datatype, note: values can be assigned explicitly
        /// </summary>
        enum Cards { Seven = 7, Eight, Nine, Ten, Knave = 20, Queen, King, Ass = 100, As = 100 };
    }


}
