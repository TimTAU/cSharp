using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

/*
 * parallel programming: http://msdn.microsoft.com/de-de/library/dd460693(v=vs.110).aspx
 * TPL: http://msdn.microsoft.com/de-de/library/dd460717(v=vs.110).aspx
 * concurrent collections: http://msdn.microsoft.com/en-us/library/system.collections.concurrent.aspx
 * 
 */
namespace B_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Task, not started
            Task T1 = new Task(
                () => Console.WriteLine("-- T1: performing task")
            );
            Console.WriteLine("main thread: start T1");
            T1.Start();
            Console.WriteLine("main thread: wait for T1");
            T1.Wait();
            Console.WriteLine("main thread: T1 joined \n");

            // create Task and start
            Console.WriteLine("main thread: start T2");
            Task T2 = Task.Run(
                () => Console.WriteLine("-- T2: performing task")
            );
            Console.WriteLine("main thread: wait for T2");
            T2.Wait();
            Console.WriteLine("main thread: T2 joined \n");

            // create Task via factory
            Console.WriteLine("main thread: start T3");
            Task T3 = Task.Factory.StartNew(
                () => Console.WriteLine("-- T3: performing task")
            );
            Console.WriteLine("main thread: wait for T3");
            T3.Wait();
            Console.WriteLine("main thread: T3 joined \n");

            // Task.Factory.StartNew" vs "new Task(...).Start
            // see: https://devblogs.microsoft.com/pfxteam/task-factory-startnew-vs-new-task-start/
            // 
            // and StartNew vs. Run: run convenient way w.o. much parameters
            // e.g. for long running tasks
            // 
            Console.WriteLine("3) output thread main");


            // "The Result property blocks the calling thread until the task finishes."
            Console.WriteLine("main thread: start T4");
            Task<int> T4 = Task<int>.Factory.StartNew(
                () => 1
            );
            Console.WriteLine("main thread: wait for T4.Result");
            int n = T4.Result;
            Console.WriteLine("main thread: T4 result: " + n + "\n");


            // "Return a named reference type with a multi-line statement lambda."
            Console.WriteLine("main thread: start T5");
            Task<Data> T5 = Task<Data>.Factory.StartNew(
                () =>
                {
                    string s = ".NET";
                    double d = 4.0;
                    return new Data {Name = s, Number = d};
                }
            );
            Console.WriteLine("main thread: wait for T5.Result");
            Data test = T5.Result;
            Console.WriteLine("main thread: T5 result: " + test.Name + "," + test.Number + "\n");


            // Wait on a single task with a timeout specified.
            Console.WriteLine("main thread: start T6");
            Task T6 = Task.Factory.StartNew(() => Thread.Sleep(1000));
            Console.WriteLine("main thread: wait for T6, max. 100ms");
            T6.Wait(100); // 100 ms.
            Console.WriteLine("main thread: T6, completed? " + T6.IsCompleted + "\n");
            T6.Wait();
            Console.WriteLine("main thread: T6, now? " + T6.IsCompleted + "\n");

            // start multiple Tasks
            Console.WriteLine("main thread: start T7, 10 tasks");
            Task[] T7 = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                T7[i] = Task.Factory.StartNew(() => Thread.Sleep(1000));
            }

            Console.WriteLine("main thread: wait for T7, all");
            Task.WaitAll(T7); // analog WaitAny
            Console.WriteLine("main thread: T7 joined \n");

            // chaining
            Console.WriteLine("main thread: start task chain");
            Task.Factory.StartNew<int>(() => 8) // 8
                .ContinueWith(ant => ant.Result * 2) // 16
                .ContinueWith(ant => Math.Sqrt(ant.Result)) // 4
                .ContinueWith(ant => Console.WriteLine("  ant.result=" + ant.Result)); // 4
            Console.WriteLine("main thread: task chain done \n");
            // analog:  Task.Factory.ContinueWhenAll(set of tasks)


            // Parallel class

            Console.WriteLine("main thread: start Parallel loops - list");

            List<int> list = new List<int>();
            Parallel.For(0, 10, (i) => list.Add(i * 2)); // here is a problem ...
            Parallel.ForEach<int>(list, (i) => Console.WriteLine("  i=" + i));

            Console.WriteLine("main thread: parallel list done \n");


            Console.WriteLine("main thread: start Parallel loops - bag");

            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Parallel.For(0, 10, (i) => bag.Add(i * 2)); // here it is solved ...
            Parallel.ForEach<int>(bag, (i) => Console.WriteLine("  i=" + i));

            // for "concurrent list" see e.g.
            // https://stackoverflow.com/questions/6601611/no-concurrentlistt-in-net-4-0

            Console.WriteLine("main thread: parallel bag done \n");
        }
    }

    class Data
    {
        public string Name { get; set; }
        public double Number { get; set; }
    }
}