// a.voss@fh-aachen.de
//
// Verwendung verschiedener Aufrufmöglichkeiten (call by value, call by reference).
//

using System;

namespace B_CallByValAndRef
{
    class Program
    {
        static void Main(string[] args)
        {
            // call by value -> n is not modified
            int n = 23;
            f_value(n);
            Console.WriteLine("1) n=" + n);

            // call by reference, n is modified
            // f_ref(n); does not work
            f_ref(ref n);
            Console.WriteLine("2) n=" + n);

            // note: object o is not initialised -> use out, not ref
            object o; //  = new object();
            f_out(out o);

            // variable number of arguments
            n = f_sum(5, 1, 2, 3, 4, 5, 6);
//          n = f_sum(5, new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine("3) n=" + n);

        }
        
        #region helper functions for call by value and ref

        static void f_value(int n)
        {
            n = 0;
        }

        static void f_ref(int n)
        {
            n = 0;
        }

        static void f_ref(ref int n)
        {
            n = 0;
        }

        static void f_out(out object o)
        {
            //o = null;
            o = new Random();
        }

        static int f_sum(int m, params int[] a)
        {
            int sum = m;
            foreach (int n in a)
                sum += n;
            return sum;
        }
        
        #endregion

    }
}