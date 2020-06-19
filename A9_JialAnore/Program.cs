using System;
using System.Threading;

namespace A9_JialAnore
{
    internal class Program
    {
        static volatile int _groessterTeiler;
        static volatile int _groessteTeilerAnzahl;

        public static void Main(string[] args)
        {
            long n = 100000;
            Worker worker1 = new Worker(n);
            Worker worker2 = new Worker(n);
            Thread thread1 = new Thread(worker1.DoWork) {Name = "Thread1"};
            Thread thread2 = new Thread(worker2.DoWork) {Name = "Thread2"};

            var time = DateTime.Now;

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            Console.WriteLine("counter = {0} after: {1}", _groessteTeilerAnzahl, DateTime.Now - time);
            Console.WriteLine("Zahl = {0}", _groessterTeiler);
        }

        private class Worker
        {
            private long _n;

            public Worker(long n)
            {
                _n = n;
            }

            private static object global_lock = new object();

            public void DoWork()
            {
                for (int i = 0; i <= _n; i++)
                {
                    // Hier werden alle is doppelt behandelt. FIXME
                    lock (global_lock)
                    {
                        var s = 0;

                        for (var j = 2; j <= i / 2; j++)
                        {
                            if (i % j == 0) s += j;
                        }

                        if (i % 10000 == 0)
                        {
                            Console.WriteLine(i);
                        }

                        if (i % 1000 == 0)
                        {
                            Console.Write(".");
                        }

                        if (s > _groessteTeilerAnzahl)
                        {
                            _groessteTeilerAnzahl = s;
                            _groessterTeiler = i;
                        }
                    }
                }
            }
        }
    }
}