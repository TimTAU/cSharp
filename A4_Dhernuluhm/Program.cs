using System;

namespace A4_Dhernuluhm
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.0;
            Func<double, double> f = x => 1.0 - a / Math.Pow(x, 2);
            Func<double, double> fStrich = x => 2 * a / Math.Pow(x, 3);
            Console.WriteLine($"Wurzel {a} = {Newton(1.5, f, fStrich)}");

            MathFunction mf = x => 1.0 - a / Math.Pow(x, 2);
            MathFunction mfStrich = x => 2 * a / Math.Pow(x, 3);
            // Invoke, da ein delegate nicht einfach so zu einer Func umgewandelt werden kann
            Console.WriteLine($"Wurzel {a} = {Newton(1.5, mf.Invoke, mfStrich.Invoke)}");
        }

        static double Newton(double xn, Func<double, double> f, Func<double, double> fStrich)
        {
            int n = 0;
            double fn = f(xn);
            while (n < 20 && Math.Abs(fn) > 1e-10)
            {
                ++n;
                xn -= fn / fStrich(xn);
                fn = f(xn);
            }

            return xn;
        }
        
        delegate double MathFunction(double x);
    }
}