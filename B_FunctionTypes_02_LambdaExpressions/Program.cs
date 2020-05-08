using System;
using System.Collections.Generic;

namespace B_FunctionTypes_02_LambdaExpressions {
    class Program {
        static void Main(string[] args) {
            var words = new List<string> {"This", "is", "one", "simple", "list."};

            // sort depends on some sorting criteria, here string implements IComparable
            words.Sort();
            Console.Write("01) std:");
            foreach (var w in words)
                Console.Write($" {w}");
            Console.WriteLine();

            // now the other way around

            // use a comparison function
            words.Sort(MyStringComp);
            Console.Write("02) inv:");
            foreach (var w in words)
                Console.Write($" {w}");
            Console.WriteLine();

            // now sort according to word length

            // use a delegate with code
            Comparison<String> noLambda = delegate(string a, string b) {
                // note: usually 0 is given back for equal length
                return (a.Length < b.Length) ? -1 : 1;
            };
            words.Sort(noLambda);
            Console.Write("03) del:");
            foreach (var w in words)
                Console.Write($" {w}");
            Console.WriteLine();

            // use a lambda expression
            Comparison<String> lambda = (a, b) => (a.Length > b.Length) ? -1 : 1;
            words.Sort(lambda);
            Console.Write("04) cmp:");
            foreach (var w in words)
                Console.Write($" {w}");
            Console.WriteLine();

            // now sort classical with an anonymous lambda expression
            words.Sort((a, b) => a.CompareTo(b));
            Console.Write("05) lmd:");
            foreach (var w in words)
                Console.Write($" {w}");
            Console.WriteLine();

            // note: multi-line lambda expressions are possible using code-blocks {}

            n2n f = x => x * x; // inline delegate
            Console.WriteLine("06) 3*3=" + f(3));

            Func<String, String, int> func = (a, b) => (a.Length > b.Length) ? -1 : 1;
            int cmp = func("abc", "def");
            Console.WriteLine("07) cmp strings=" + cmp);

            // note: a lambda expression can be converted to any delegate whos signature fits
        }

        /// <summary>
        /// a simple string comparer
        /// </summary>
        static int MyStringComp(string a, string b) { return b.CompareTo(a); }

        delegate int n2n(int n);
    }
}