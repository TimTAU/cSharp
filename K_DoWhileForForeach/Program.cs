using System;

namespace K_DoWhileForForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // some equivalent loops

            int i;

            Console.Write("while:     ");
            i = 1;
            while (i < 10)
            {
                Console.Write(" i:" + i);
                ++i;
            }
            Console.Write("\n");

            Console.Write("do-while:  ");
            i = 1;
            do
            {
                Console.Write(" i:" + i);
                ++i;
            } while (i < 10);
            Console.Write("\n");

            Console.Write("for:       ");
            for (int j = 1; j < 10; ++j)
            {
                Console.Write(" j:" + j);
            }
            Console.Write("\n");
            // note: at this point j is not accessable anymore 

            Console.Write("for break: ");
            // beak und continue
            for (int j = -10; j < 100; ++j)
            {
                if (j < 1)
                    continue;       // next for loop
                if (j >= 10)
                    break;          // end for loop
                Console.Write(" j:" + j);
            }
            Console.Write("\n");

            Console.Write("crazy for:");
            // multiple initialisations and end-statements possible
            for (int j = 1, k = 1; j + k < 10 && j + k > 0; j += 1, k += 2)
            {
                Console.Write(" j,k:" + j + "," + k);
            }
            Console.Write("\n");

            // empty parts possible
            i = 1;
            for (; i < 10;)
            {
                ++i;
            }

            // traverse all elements
            Console.Write("array a1:   ");
            int[] a1 = { 2, 3, 5, 7, 11, 13 };
            foreach (int n in a1)
            {
                Console.Write(" n=" + n);
            }
            Console.Write("\n");

            Console.Write("array a2:   ");
            string[] a2 = "Word1 Word2 Word3".Split(' ');
            foreach (var s in a2)
            {
                Console.Write(" s=" + s);
            }
            Console.Write("\n");
        }
    }
}
