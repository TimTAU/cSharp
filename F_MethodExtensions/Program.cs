using System;

namespace F_MethodExtensions
{
    static class Program
    {
        static void Main(string[] args)
        {
            String s = "Hello!";

            // call extension method with parameter
            Console.WriteLine($"1) s={s}, s[2]={s.nthChar(2)}");
            Console.WriteLine($"2) turn s={s.turn()}");

            B b = new B {ID = 12};
            Console.WriteLine($"3) b: {b.asText(10)}");
        }

        /// <summary>
        /// - extension method with a parameter
        /// - has to be public static in a static class
        /// - the class to be extended is given by "this"
        /// </summary>
        public static char nthChar(this string str, int idx)
        {
            return str[idx];
        }

        public static string turn(this string str)
        {
            char[] a = str.ToCharArray();
            Array.Reverse(a);
            return new string(a);
        }

        public class A
        {
            public int ID { get; set; }
        }

        public class B : A
        {
        }

        public static string asText(this A a, int n)
        {
            return $"ID={a.ID}, n={n}";
        }
    }
}