using System;

namespace H_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // indices start at 0 

            // fixed length
            int[] a1;           // cannot be used! 
            a1 = new int[4];    // now a1[0] .. a1[3] exist
            a1[0] = 12;
            Console.WriteLine("a1     = " + a1);
            Console.WriteLine("a1[0]  = " + a1[0]);
            Console.WriteLine("a1[1]  = " + a1[1]); // default
            Console.WriteLine();

            // various initializations
            int[] a2 = new int[5] { 2, 3, 5, 7, 11 };
            int[] a3 = new int[] { 2, 3, 5, 7 };
            int[] a4 = { 2, 3, 5, 7, 11, 13 };

            Console.WriteLine("a1-Len = " + a1.Length);
            Console.WriteLine("a2-Len = " + a2.Length);
            Console.WriteLine("a3-Len = " + a3.Length);
            Console.WriteLine("a4-Len = " + a4.Length);
            Console.WriteLine();

            // rectangle 2D arrays
            int[,] b1 = new int[2, 3];
            int[,] b2 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            Console.WriteLine("b1-dim0= " + b1.GetLength(0));   // length in n'th dimension
            Console.WriteLine("b1-dim1= " + b1.GetLength(1));
            Console.WriteLine("b2[1,2]= " + b2[1, 2]);
            Console.WriteLine("b2-dim0= " + b2.GetLength(0));
            Console.WriteLine("b2-dim1= " + b2.GetLength(1));

            // etc. var z1 = new int[2, 3, 4];

            int nDim = int.Parse(Console.ReadLine());
            int[] a5 = new int[nDim];

            Console.WriteLine("a5 " + a5[0]);
        }
    }
}