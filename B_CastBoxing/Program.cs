using System;

namespace B_CastBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 42;
            object o = n; // Boxing
            Console.WriteLine($"1) n={n}, o={o}");

            int m = (int) o; // Unboxing
            Console.WriteLine($"2) m={m}");

            // value of o?
            n = 5;
            Console.WriteLine($"3) n={n}, o={o}");

            // and now?
            S s = new S() {Name = "Klaus"};
            Console.WriteLine($"4) s.Name={s.Name}");
            INameable si = s;
            Console.WriteLine($"5) si.Name={si.Name}");
            s.Name = "Hans";
            Console.WriteLine($"6) s.Name={s.Name}, si.Name={si.Name}");
        }

        interface INameable
        {
            string Name { get; set; }
        }

        // compare to class
        struct S : INameable
        {
            public string Name { get; set; }
        }
    }
}