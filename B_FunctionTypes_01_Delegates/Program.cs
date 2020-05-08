using System;

namespace B_FunctionTypes_01_Delegates {
    class Program {
        static void Main(string[] args) {
            // f is a math function with double argument, returning a double
            // one way to initialise f
            MathFunction f = new MathFunction(Math.Sin);
            // or simply by setting
            f = Math.Cos;
            // use it
            Console.WriteLine("01) f(pi)=" + f(Math.PI));

            var values = new double[] {0, 1 * Math.PI, 2 * Math.PI};
            WriteValues(values, "sin", Math.Sin);
            WriteValues(values, "cos", Math.Cos);

            // delegates can be collected (+= op), such as Event-Handlers

            // Lambda-Expression-Syntax, preview, see exercise
            double a = 2.0;
            MathFunction g = x => 1.0 - a / (x * x);
            MathFunction dg = x => 2 * a / (x * x * x);

            // Console.WriteLine("03) sqrt 2=...");
            // double y = Newton(3, 1.5, g, dg);
            // Console.WriteLine($"04) sqrt 2={y}");
        }

        /// <summary>
        /// some math function, e.g. sin
        /// </summary>
        delegate double MathFunction(double x);

        //double Integral(double a, double b, double h, MathFunction f) ...
        //double Newton(double x0, MathFunction f, MathFunction df, double eps) ...

        /// <summary>
        /// applies all values to f and writes the results
        /// </summary>
        static void WriteValues(double[] values, string name, MathFunction f) {
            Console.WriteLine($"02) {name}:");
            foreach (var v in values)
                Console.WriteLine($"      {v} -> {f(v)}");
        }

    }
}