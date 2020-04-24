using System;

namespace A1_Awhya
{
    class Program
    {
        static void Main(string[] args)
        {
            double lrs = 0;
            for (int i = 1; i <= 10000; i++)
            {
                if (i % 2 == 0)
                {
                    lrs -= 1.0 / i;
                }
                else
                {
                    lrs += 1.0 / i;
                }
            }

            Console.WriteLine(lrs);
            Console.WriteLine("-----");

            double rls = 0;
            for (int i = 10000; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    rls -= 1.0 / i;
                }
                else
                {
                    rls += 1.0 / i;
                }
            }

            Console.WriteLine(rls);
            Console.WriteLine("-----");

            double ps = 0;
            double ns = 0;
            for (int i = 1; i <= 10000; i++)
            {
                if (i % 2 == 0)
                {
                    ns -= 1.0 / i;
                }
                else
                {
                    ps += 1.0 / i;
                }
            }

            double gs = ps + ns;
            Console.WriteLine(gs);
        }
    }
}