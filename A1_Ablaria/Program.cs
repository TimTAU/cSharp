using System;
using System.Collections.Generic;

namespace A1_Ablaria
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var VARIABLE in Primenumbers(30))
            {
                Console.WriteLine(VARIABLE);
            }
        }

        static List<int> Primenumbers(int n)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (nextPrime < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }
    }
}