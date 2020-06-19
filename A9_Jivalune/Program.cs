using System;
using System.Threading;

namespace A9_Jivalune
{
    internal class Program
    {
        static volatile int counter = 0;

        public static void Main(string[] args)
        {
            long n = 100000;
            Worker worker = new Worker(1, n);
            Thread thread = new Thread(worker.DoWork) {Name = "Thread"};

            var time = DateTime.Now;
            
            thread.Start();
            thread.Join();

            Console.WriteLine("counter = {0} after one thread: {1}", counter, DateTime.Now - time);

            n = 0;
            Worker worker1 = new Worker(1, n);
            Worker worker2 = new Worker(1, n);
            Thread thread1 = new Thread(worker1.DoWork) {Name = "Thread1"};
            Thread thread2 = new Thread(worker2.DoWork) {Name = "Thread2"};

            var time2 = DateTime.Now;
            
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            
            Console.WriteLine("counter = {0} after two threads: {1}", counter, DateTime.Now - time2);
        }

        private class Worker
        {
            private int _id;
            private long _n;

            public Worker(int id, long n)
            {
                _id = id;
                _n = n;
            }

            public void DoWork()
            {
                for (int i = 0; i <= _n; i++)
                {
                    Interlocked.Add(ref counter, i);
                }
            }
        }
    }
}