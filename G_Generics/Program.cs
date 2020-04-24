using System;
using System.Collections;
using System.Collections.Generic;

namespace G_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();  // objects

            a.Add(12);
            a.Add(2.3);
            a.Add("Hello");

            //string s = a[1];

            foreach (object o in a)
            {
                Console.WriteLine($"1) obj-element: {o}");
            }

            List<string> l = new List<string>();

            l.Add("a string object");
            string s = l[0];
            Console.WriteLine($"2) str-element: {s}");

            Point_T<double> pt1 = new Point_T<double> { x = 31.2, y = 35.6 };
            Console.WriteLine($"3) <T> pt1: {pt1}\n");
        }
    }
    /// <summary>
    /// a sample generic type, also works for structs and functions
    /// </summary>
    class Point_T<T>
    {
        public T x, y;

        public override string ToString()
        {
            return string.Format("x={0}; y={1}", this.x, this.y);
        }
    }
}