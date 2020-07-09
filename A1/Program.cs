using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Aufgabe 1.1");
            Node nodeConstructorTest = Node.Make(0, 1.123, 2.345678, 7.0);
            Console.WriteLine(nodeConstructorTest);

            Console.WriteLine("--- Aufgabe 1.2");
            static double f(double x, double y) => Math.Pow(x, 2);
            static double ye(double x) => 1 / (2 - x);

            foreach (var node in EulerTest(0.8, 1.8, 10, f, ye))
            {
                Console.WriteLine(node);
            }

            Console.WriteLine("--- Aufgabe 1.2d");
            var res = from node in EulerTest(0.8, 1.8, 1000, f, ye)
                where (node.n % 100) == 0
                select new {n = node.n, yn = node.yn};
            foreach (var node in res)
            {
                Console.WriteLine(node);
            }
        }

        //Würde man die Aufgaben vorher lesen, müsste man das auch nicht zwei Mal machen
        /*static void Euler(double a, double b, Func<double, double, double> yStrich, double y0, int N)
        {
            double h = (b - a) / N;
            static double ye(double x) => 1 / (2 - x);

            for (int n = 0; n <= N; n++)
            {
                var xn = a + n * h;
                var errn = y0 - ye(xn);
                Console.WriteLine($"n={n}    x_n={xn}    y_n={y0}    err_n={errn}");

                y0 = y0 + h * yStrich(xn, y0);
            }
        }*/

        //A1.2
        static IEnumerable<Node> EulerTest(double a, double b, int N, Func<double, double, double> f,
            Func<double, double> ye)
        {
            double h = (b - a) / N;
            var yn = ye(a);
            for (int n = 0; n <= N; n++)
            {
                double xn = a + n * h;
                double errn = yn - ye(xn);

                yield return Node.Make(n, xn, yn, errn);

                yn = yn + h * f(xn, yn);
            }
        }
    }

    //A1.1
    class Node : Tuple<int, double, double, double>
    {
        private Node(int n, double xn, double yn, double errn) : base(n, xn, yn, errn)
        {
        }

        //Könnten privat gemacht werden, da sie nur in der ToString Methode verwendet werden 
        public int n => Item1;
        public double xn => Item2;
        public double yn => Item3;
        public double errn => Item4;

        public static Node Make(int n, double xn, double yn, double errn)
        {
            return new Node(n, xn, yn, errn);
        }

        public override string ToString()
        {
            return $"n={n}    xn={xn:G4}    yn={yn:G4}    errn={errn:G4}";
        }
    }
}