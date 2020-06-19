using System;
using System.Threading;

namespace B_Mutex
{
    class Program
    {
        static volatile int counter = 0;
        static Mutex global_mutex = new Mutex();

        static void Main(string[] args)
        {
            long n = 100000;
            Worker w1 = new Worker(1, +1, n);
            Worker w2 = new Worker(2, -1, n);
            Thread t1 = new Thread(w1.DoWorkB) {Name = "t1"};
            Thread t2 = new Thread(w2.DoWorkB) {Name = "t2"};

            Console.WriteLine("{0} | main thread - {1}", DateTime.Now, "started");

            // simply start some threads and wait for their end
            t1.Start();
            t2.Start();

            Console.WriteLine("{0} | main thread - {1}", DateTime.Now, "threads started, wait for joins");

            t1.Join();
            t2.Join();

            Console.WriteLine("{0} | main thread - {1}", DateTime.Now, "threads joined");

            Console.WriteLine("counter = {0}", counter);
        }

        public class Worker
        {
            public Worker(int _id, int _inc, long _n)
            {
                id = _id;
                inc = _inc;
                n = _n;
            }

            private int id;
            private int inc;
            private long n;

            public void DoWorkA() // threads main method
            {
                for (long i = 0; i < n; ++i)
                    counter += inc; // counter = counter+inc
            }

            public void DoWorkB() // threads main method
            {
                for (long i = 0; i < n; ++i) // where is the problem here?
                {
                    global_mutex.WaitOne(); // wait for entry
                    counter += inc;
                    global_mutex.ReleaseMutex(); // call it the same number as WaitOne before
                }
            }

            public static object global_lock = new object();

            public void DoWorkC() // threads main method
            {
                for (long i = 0; i < n; ++i)
                {
                    lock (Worker.global_lock)
                    {
                        counter += inc;
                    }

                    /*  // long version:
                        Monitor.Enter(Worker.global_lock);
                        try
                        {
                            // global work
                        }
                        finally
                        {
                            Monitor.Exit(Worker.global_lock);   // always use finally!
                        }
                     */
                }
            }

            public void DoWorkD() // threads main method
            {
                for (long i = 0; i < n; ++i)
                {
                    Interlocked.Add(ref counter, inc);
                }
            }
        }
    }
}