using System;

namespace I_BuildInOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // very simple
            int n1 = 1, n2 = 2, n3 = n1 + n2;
            Console.WriteLine("n1    = " + n1);
            Console.WriteLine("n2    = " + n2);
            Console.WriteLine("n3    = " + n3); // 3

            // modify and assign in one step
            n3 += 2; // n3 = n3+2
            n3 *= 5;
            Console.WriteLine("n3'   = " + n3); // 25

            // result of a comparison is bool
            bool b = (n3 > 0);
            int n4 = (n3 > 0) ? 1 : -1;         // an operator with three operands
            int n5 = b ? 1 : -1;
            Console.WriteLine("b   . = " + b);
            Console.WriteLine("Vorz. = " + n4); // 1
            Console.WriteLine("Vorz. = " + n5); // 1

            // prefix and postfix modifier
            int n6 = 12;
            int n7 = 2 * (++n6);
            int n8 = 2 * (n6++);
            Console.WriteLine("n6    = " + n6);
            Console.WriteLine("n7    = " + n7);
            Console.WriteLine("n8    = " + n8);

            double d1 = 3.5, d2 = 10.0, d3 = d1 * d2;
            Console.WriteLine("d1    = " + d1);
            Console.WriteLine("d2    = " + d2);
            Console.WriteLine("d3    = " + d3); // 35

            // logical operators
            bool b1 = true;
            bool b2 = false;
            bool b3 = b1 || b2;     // or
            bool b4 = b1 && b2;     // and
            bool b5 = !b4;          // not
            Console.WriteLine("b1    = " + b1);
            Console.WriteLine("b2    = " + b2);
            Console.WriteLine("b3    = " + b3);
            Console.WriteLine("b4    = " + b4);
            Console.WriteLine("b5    = " + b5);

            // some casting
            double f1 = n8;         // no cast necessary
            float f2 = (float)d1;   // not enough accuracy
            int nn = (int)f1;

            // nn = f1 as float;  geht nicht

            // multiple assignment
            f1 = f2 = (float)(n8);
        }
    }
}
