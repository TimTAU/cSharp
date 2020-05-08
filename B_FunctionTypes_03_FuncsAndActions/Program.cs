using System;

namespace B_FunctionTypes_03_FuncsAndActions {
    class Program {
        static void Main(string[] args) {
            //func with delegate
            Func<string, string> convert1 = delegate(string s) { return s.ToUpper(); };

            //func with lambda
            Func<string, string> convert2 = s => s.Substring(3, 10);

            // func with existing function
            Func<string, string> convert3 = S;

            //action
            Action<int, string> output = (i, title) => {
                Console.WriteLine($"04) {title}:");
                Console.WriteLine($"      Adding five to {i}={i+5}");
            };

            Console.WriteLine($"01) {convert1("This is the first test.")}");
            Console.WriteLine($"02) {convert2("This is the second test.")}");
            Console.WriteLine($"03) {convert3("This is the third test.")}");

            output(5, "First one");
            output(3, "Second one");
        }

        static string S(string s) { return s.ToUpper(); }
    }
}