// a.voss@fh-aachen.de
//
// Gesammelte Übungen 0x04
//

using System;

namespace Z_Uebungen4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinoit();
            Dirac();
            Daugnge();
            Dallakur();
            Dhernuluhm();
        }

        delegate int TwoOps(int x, int y);

        static int Add(int x, int y) {
            return x + y;
        }

        static int Mul(int x, int y) => x * y;

        static void Dinoit()
        {
            Console.WriteLine("Dinoit");
            // eine Möglichkeit
            TwoOps add = Add;
            TwoOps mul = Mul;
            // oder so
            Func<int, int, int> ladd = (x,y) => x + y;
            var lmul = new Func<int, int, int>(Mul);
            Console.WriteLine($"  2+3={add(2,3)}");
            Console.WriteLine($"  2*3={mul(2,3)}");
            Console.WriteLine($"  2+3={ladd(2,3)}");
            Console.WriteLine($"  2*3={lmul(2,3)}");
        }
        
        delegate double Trigonom(double x);
        
        static void Dirac()
        {
            Console.WriteLine("Dirac");

            var fs = new Trigonom[] {Math.Sin, Math.Cos, Math.Tan};
            double x = 0.0;
            while (x < 0.5) { // bis 2PI
                Console.Write($"  {x:0.00} => [");
                foreach (var f in fs) {
                    Console.Write($"  {f(x):0.0000}");
                }
                Console.WriteLine("]");
                x += 0.1;
            }
        }

        static double eval(double x, Func<double, double> f) => f(x);
        
        static void Daugnge()
        {
            Console.WriteLine("Daugnge");

            var fx = eval(3, x => x * x);
            Console.WriteLine($"  3^2={fx}");
        }

        static void Dallakur()
        {
            Console.WriteLine("Dallakur");

            Func<double, double, double, double> add = (x,y,z) => x + y + z;
            Console.WriteLine($"  2+3+4={add(2,3,4)}");
            
            Func<int, int, int, bool> inside = (x,a,b) => (a<=x && x<=b);
            Console.WriteLine($"  2 in [3,4]={inside(2,3,4)}");
            Console.WriteLine($"  3 in [3,4]={inside(3,3,4)}");
        }
        
        static void Dhernuluhm()
        {
            Console.WriteLine("Dhernuluhm");
            double a = 2.0;
            Func<double, double> g = x => 1.0 - a / (x * x);
            Func<double, double> dg = x => 2 * a / (x * x * x);

            Console.WriteLine("03) sqrt 2=...");
            Console.WriteLine($"04) sqrt 2={Newton(1.5, g, dg)}");

        }
        
        static double Newton(double xn, Func<double, double> f, Func<double, double> df) {
            // konvergiert quadratisch, aber lokal, d.h. evtl. auch gar nicht... daher max. Grenze
            var n = 0;
            var fn = f(xn);
            while (n < 10 && Math.Abs(fn) > 1e-10) {
                Console.WriteLine($"  n={n}, x_n={xn}, err={fn}");
                ++n;
                xn = xn - fn / df(xn);
                fn = f(xn);
            }

            return xn;
        }
        
    }
}
