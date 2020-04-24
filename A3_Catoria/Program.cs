using System;
using System.Collections.Generic;

namespace A3_Catoria
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            queue.Remove();
            queue.Add(5);
            Console.WriteLine(queue.ShowAndClear());
        }
    }

    class Queue<T>
    {
        public Queue()
        {
            QueueList = new List<T>();
        }

        private List<T> QueueList{ get; set; }

        public void Add(T element)
        {
            QueueList.Insert(0, element);
        }

        public void Remove()
        {
            QueueList.RemoveAt(0);
        }

        public string ShowAndClear()
        {
            string queueString = ToString();
            QueueList = new List<T>();
            return queueString;
        }

        public override string ToString()
        {
            return string.Join(", ", QueueList);
        }
    }
}