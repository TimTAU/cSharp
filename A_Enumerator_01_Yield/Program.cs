using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Enumerator_01_Yield {
    
    internal static class Program {
        
        private static void Main(string[] args) {
            Console.Write("01) MyList 2^j, j=1..3: ");
            foreach (int j in MyList(2, 3)) {
                Console.Write($" {j}");
            }

            Console.WriteLine();

            Console.Write("02) MyPower 2^j, j=1..3: ");
            foreach (int j in MyPower(2, 3)) {
                Console.Write($" {j}");
            }
            Console.WriteLine();
            Console.WriteLine("02a) MyPower 2^j, j=1..3: " + String.Join(',', MyPower(2, 3)));


            Console.Write("03) MyPower 2^j, j=1..3: ");
            var k = MyPower(2, 3).GetEnumerator();
            while (k.MoveNext()) {
                Console.Write($" {k.Current}");
            }

            Console.WriteLine();
            // k.Reset(); // COM Compat., most implementatios throw NotImplExc., use GetEnum() again

            var b = 1;
            var power2 = from n in Enumerable.Range(1, 3) select b *= 2;
            Console.WriteLine($"04) b={b}");
            Console.WriteLine("04) Range 2^j, j=1..3: " + String.Join(',', power2));
            Console.WriteLine($"04) b={b}");

            Console.WriteLine();
        }

        private static List<int> MyList(int b, int maxExponent) {
            var l = new List<int>();
            int cnt = 0;
            int result = 1;
            while (cnt++ < maxExponent) {
                result = result * b;
                l.Add(result);
            }

            return l;
        }

        private static IEnumerable<int> MyPower(int b, int maxExponent) {
            int cnt = 0;
            int result = 1;
            while (cnt++ < maxExponent) {
                result = result * b;
                yield return result;
            }
        }
        
    }
}