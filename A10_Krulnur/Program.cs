using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace A10_Krulnur
{
    internal class Program
    {
        static ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
        static ArrayList resultList = new ArrayList();

        public static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i <= 1000; i++)
            {
                queue.Enqueue(random.Next(1, 1000));
            }

            List<Thread> threadList = new List<Thread>();
            for (int i = 1; i <= 3; ++i)
            {
                Thread t = new Thread(DoWork) {Name = "Thread" + i};
                t.Start();
                threadList.Add(t);
            }

            foreach (Thread thread in threadList)
            {
                thread.Join();
            }

            foreach (var s in resultList)
            {
                Console.WriteLine("  s=" + s);
            }
                
        }

        private static void DoWork()
        {
            int n;
            while (queue.TryDequeue(out n))
            {
                if (n % 2 != 0)
                    lock (resultList)
                    {
                        resultList.Add(n);
                    }
            }
        }
    }
}