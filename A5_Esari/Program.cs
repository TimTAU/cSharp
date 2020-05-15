using System;
using System.Collections;
using System.Collections.Generic;

namespace A5_Esari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime bis 50: " + String.Join(',', Primenumbers(50)));
        }


        static IEnumerable<int> Primenumbers(int n)
        {
            yield return 2;
            for (int i = 3; i <= n; i++)
            {
                if (CheckPrime(i))
                {
                    yield return i;
                }
            }
        }

        static bool CheckPrime(int number)
        {
            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}