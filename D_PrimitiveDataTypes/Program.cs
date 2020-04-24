using System;

namespace D_PrimitiveDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // strings and characters
            string s = "Hallo";
            char c = 'X';
            Console.WriteLine("string  '" + s + "'");
            Console.WriteLine("char    '" + c + "'");

            // floating point variables
            float f = 1.2f;
            double d = 2.3;
            decimal z = 3.4m;           // e.g. currency (Währungen)
            // note: + (plus) to concat. output
            Console.WriteLine("float   '" + f + "'");
            Console.WriteLine("double  '" + d + "'");
            Console.WriteLine("decimal '" + z + "'");

            // byte und signed byte (s)
            byte b = 0x12;
            sbyte sb = -0x13;
            Console.WriteLine("byt     '" + b + "'");
            Console.WriteLine("sbyte   '" + sb + "'");

            // integer variables, signed and unsigned (u)
            int n0 = -42;
            uint n1 = 42;
            long l0 = -43;
            ulong l1 = 0x12;            // hexadecimal notation
            Console.WriteLine("int     '" + n0 + "'");
            Console.WriteLine("uint    '" + n1 + "'");
            Console.WriteLine("long    '" + l0 + "'");
            Console.WriteLine("ulong   '" + l1 + "'");

            // logical
            bool b0 = false;
            bool b1 = true;
            Console.WriteLine("bool F. '" + b0 + "'");
            Console.WriteLine("bool T. '" + b1 + "'");

            // math functions
            double d1 = 2.0;
            double d2 = Math.Abs(d1 - 1.5);
            double d3 = Math.PI;                // a constant
            double d4 = Math.Sin(d3);           // not declared for decimal
            double d5 = Math.Sqrt(d4);

            // note: some functions are defined for double only
            double d6 = 0.85;
            int m = (int)Math.Floor(d6 * 10.0);  // greatest int-number below or equal
            Console.WriteLine("d6'   = " + d6);
            Console.WriteLine("m'    = " + m);

            Console.WriteLine(Math.Pow(2.5, 4));

            // 0.6931471305599478094172320036
            double sum, mul;
            double erg = (double)0.6931471305599478094172320036m;

            sum = 0.0;
            mul = 1.0;
            for (int i = 1; i <= 10000000; ++i, mul *= -1.0)
                sum += 1.0 / (mul * i);
            Console.WriteLine("sum=" + sum + ", diff=" + (sum - erg));

            sum = 0.0;
            mul = -1.0;
            for (int i = 10000000; i >= 1; --i, mul *= -1.0)
                sum += 1.0 / (mul * i);
            Console.WriteLine("sum=" + sum + ", diff=" + (sum - erg));
        }
    }
}
