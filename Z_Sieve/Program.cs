using System;
using System.Diagnostics;

// http://de.wikipedia.org/wiki/Sieb_des_Eratosthenes

namespace Z_Sieve
{
    class Program
    {
        class SiebSimple
        {
            public bool[] Sieb;

            public long Size { get; set; }

            public SiebSimple(long n)
            {
                Size = n;
                Sieb = new bool[Size];
            }

            public void Reset()
            {
                for (long i = 0; i < Size; ++i)
                    Sieb[i] = false;
            }

            // ganz einfache Variante!
            public void CalcPrimes()
            {
                Sieb[0] = Sieb[1] = true; // not prime
                for (long i = 2; i < Size; ++i)
                {
                    if (Sieb[i])
                        continue;
                    for (long k = i + i; k < Size; k += i)
                        Sieb[k] = true;
                }
            }
        }

        static void Main(string[] args)
        {
            const long n = 100;
            SiebSimple S = new SiebSimple(n);
            Stopwatch StopWatch = new Stopwatch();

            S.Reset();
            StopWatch.Start();
            S.CalcPrimes();
            StopWatch.Stop();
            TimeSpan ts = StopWatch.Elapsed;

            Console.WriteLine("Benötigte Zeit: {0:00}.{1:000} [s]", ts.Seconds, ts.Milliseconds);
            Console.Write("Größten 10 Primzahlen:");
            for (long i = n - 1, cnt = 0; i >= 0 && cnt < 10; --i)
                if (!S.Sieb[i])
                {
                    Console.Write(" " + i);
                    ++cnt;
                }

            Console.WriteLine();

            // und jetzt parallel ... 

            /* insert code here */
        }
    }
}