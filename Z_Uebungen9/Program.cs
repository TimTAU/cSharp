// a.voss@fh-aachen.de
//
// Gesammelte Übungen 0x04
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using System.Threading;

namespace Z_Uebungen9
{
    class Program
    {
        static void Main(string[] args)
        {
            Jivalune();
            // JieThalor
            // -> wie Jivalune Aufteilen der Summanden in der Summe über f(a+ih)
            //    Hintergrund: die Auswertung von f könnte teuer sein, dann macht das Sinn
            JialAnore();
        }

        static void Jivalune()
        {
            Console.WriteLine("Jivalune");
            var N = 100;
            var w1 = new Worker {Von = 1, Bis = N / 2};
            var w2 = new Worker {Von = N / 2 + 1, Bis = N};
            Thread t1 = new Thread(w1.DoWork) {Name = "w1"};
            Thread t2 = new Thread(w2.DoWork) {Name = "w2"};

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine($"Sum W1 = {w1.Sum}, Sum W2 = {w2.Sum}, Sum = {w1.Sum + w2.Sum}");

            Console.WriteLine();
        }

        class Worker
        {
            public Worker()
            {
                Sum = 0;
            }

            public int Von { get; set; }
            public int Bis { get; set; }
            public int Sum { get; private set; }

            public void DoWork()
            {
                for (var i = Von; i <= Bis; Sum += (i++))
                {
                }
            }
        }

        static void JialAnore()
        {
            Console.WriteLine("JialAnore");

            // Ansatz Producer-Consumer-Pattern mit einer Menge von Aufgaben (Zahlen),
            // die getestet werden - hier aber einfacher, ein "globaler" Zähler, der
            // allerdings ein geboxtes Object ist, das "gelockt" werden kann...
            Searcher.N = 32;

            var searchers = new List<Searcher>();
            const int numThreads = 4;
            for (var i = 0; i < numThreads; ++i)
            {
                searchers.Add(Searcher.NewStartedSearcher());
            }

            // Suche läuft...

            foreach (var searcher in searchers)
            {
                searcher.WaitForCompletion();
            }

            // angenommen, es gibt ein Element;
            // hier nutzen wir aus, dass wir die searchers sortierbar gemacht haben
            var maxNumber = searchers.Max();
            Console.WriteLine($"max. Element:{maxNumber.Number}, Teiler:{maxNumber.FactorCnt}");

            Console.WriteLine();
        }

        class Searcher : IComparable<Searcher>
        {
            public static Object N = 12;

            public static Searcher NewStartedSearcher()
            {
                return new Searcher().Start();
            }

            public int FactorCnt { get; private set; }
            public int Number { get; private set; }

            readonly Thread thread;

            private Searcher()
            {
                FactorCnt = 0;
                thread = new Thread(this.DoWork);
            }

            private Searcher Start()
            {
                thread.Start();
                return this;
            }

            public void WaitForCompletion()
            {
                thread.Join();
            }

            private void DoWork()
            {
                while ((int) N > 0)
                {
                    int nextNumber;
                    lock (N)
                    {
                        nextNumber = (int) N;
                        if (nextNumber > 0)
                        {
                            // Achtung: doppelter Check notwendig!
                            N = nextNumber - 1;
                        }
                    }

                    if (nextNumber > 0)
                    {
                        // die Berechnung nicht innerhalb von lock! 
                        var cnt = 0;
                        for (var i = 1; i <= nextNumber; ++i)
                            if (nextNumber % i == 0)
                                ++cnt;
                        if (cnt > FactorCnt)
                        {
                            FactorCnt = cnt;
                            Number = nextNumber;
                        }
                    }
                }
            }

            public int CompareTo(Searcher other)
            {
                return (FactorCnt != other.FactorCnt)
                    ? FactorCnt.CompareTo(other.FactorCnt)
                    : Number.CompareTo(other.Number);
            }
        }
    }
}