using System;

namespace A4_Daugnge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funktion definieren
            Func<double, double> f2 = d => Math.Pow(d, 2);
            Console.WriteLine(Eval(f2, 5));

            // Lokale Funktion
            //Innen definieren
            double f(double d) => Math.Pow(d, 2);
            Console.WriteLine(Eval(f, 5));

            //Lambd
            Console.WriteLine(Eval(x => Math.Pow(x, 2), 5));
        }

        private static double Eval(Func<double, double> f, double x)
        {
            return f(x);
        }

        // Lokale Funktion außen definieren
        // static double f(double d) => Math.Pow(d, 2);
    }
}