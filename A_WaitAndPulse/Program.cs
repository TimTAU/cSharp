using System;
using System.Threading;

namespace A_WaitAndPulse
{
    class Program
    {
        static void Main(string[] args)
        {
            // wait and pulse pattern! http://www.albahari.com/threading/part4.aspx#_Nonblocking_Synchronization

            Worker w1 = new Worker(1);
            Worker w2 = new Worker(2);
            Thread t1 = new Thread(w1.DoWork) {Name = "t1"};
            Thread t2 = new Thread(w2.DoWork) {Name = "t2"};

            Console.WriteLine("{0} | main thread - {1}", DateTime.Now, "started");

            t1.Start();
            t2.Start();

            Console.WriteLine("{0} | main thread - {1}", DateTime.Now, "threads wait, work for 3s");
            //Thread.Sleep(3000);         // let threads wait

            Console.WriteLine("{0} | main thread - {1}", DateTime.Now, "signal threads");

            lock (Worker.global_lock)
            {
                Worker.global_workdone = true;
                // Monitor.Pulse(Worker.global_lock);       // use this for a single thread
                Monitor.PulseAll(Worker.global_lock); // or this for all
            }

            Console.WriteLine("{0} | main thread - {1}", DateTime.Now, "waiting for join");
            t1.Join();
            t2.Join();
            Console.WriteLine("{0} | main thread - {1}", DateTime.Now, "threads joined, done");
        }

        public class Worker
        {
            public Worker(int _id)
            {
                id = _id;
            }

            private int id;
            public static object global_lock = new object();
            public static bool global_workdone = false;

            public void DoWork() // threads main method
            {
                Console.WriteLine(
                    "{0} |      thread {1:d},'{2}' - {3}", DateTime.Now, id, Thread.CurrentThread.Name,
                    "started, waiting");

                Thread.Sleep(1000);
                lock (global_lock)
                    while (!global_workdone)
                        Monitor.Wait(
                            global_lock); // it is designed to work with lock, Lock is released while we’re waiting

                Console.WriteLine(
                    "{0} |      thread {1:d},'{2}' - {3}", DateTime.Now, id, Thread.CurrentThread.Name, "working");
                Thread.Sleep(id * 1000);
                Console.WriteLine(
                    "{0} |      thread {1:d},'{2}' - {3}", DateTime.Now, id, Thread.CurrentThread.Name, "finished");
            }
        }
    }
}