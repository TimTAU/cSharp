// a.voss@fh-aachen.de
//
// Gesammelte Übungen 0x04
//

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using System.Threading;

namespace Z_Uebungen {
    class Program {
        static void Main(string[] args) {
            Krulnur();
        }

        static int NumThreads = 5;
        static CountdownEvent C = new CountdownEvent(NumThreads);

        static int MaxNumber = 12;
        static ConcurrentQueue<int> Q = new ConcurrentQueue<int>();
        static SortedSet<int> S = new SortedSet<int>(); // nicht thread-safe
        
        static void Krulnur() {
            Console.WriteLine("Krulnur");
            
            // - Problem aufsetzen und die Abarbeitung erst starten, wenn
            //   alles bereit ist
            Q.Enqueue(2);
            for (int i = 3; i <= MaxNumber; ++i)
                Q.Enqueue(i);

            // - Menge von Threads/Tasks erzeugen und starten
            List<Thread> threads = new List<Thread>();
            for (int i = 1; i <= NumThreads; ++i)
            {
                Thread t = new Thread(DoWork) { Name="T"+i };
                t.Start();
                threads.Add(t);
            }

            Console.WriteLine("1) {0} | main thread - {1}", DateTime.Now, "wait for threads");
            C.Wait();
            Console.WriteLine("2) {0} | main thread - {1}", DateTime.Now, "all started");
               
            // - Auf Ergebnis warten
            foreach (Thread thread in threads)
                thread.Join();
            Console.WriteLine("3) {0} | main thread - {1}", DateTime.Now, "joined");

            // - Ergebnisse zusammentragen
            foreach (var s in S)
                Console.WriteLine("  s=" + s);

            Console.WriteLine();
        }
        
        static public void DoWork() {
            C.Signal();

            int n;
            while (Q.TryDequeue(out n))
            {
                // hier steht die eigentliche Aufgabe an ... z.B. Primzahltest oder hier div 2
                if (n%2==0)
                    lock (S)
                    {
                        S.Add(n);   // Ergebnis gesichert ablegen
                    }
            }
        }

    }
}
