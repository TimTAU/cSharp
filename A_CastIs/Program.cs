using System;

namespace A_CastIs
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B(12);
            Console.WriteLine($"1) a.ID={a.Id} b.ID={b.Id}");

            A ra = a;
            A rb = b; // remember: b is of type A (and of type B)

            // both have a property ID
            Console.WriteLine($"2) ra.ID={ra.Id}");
            Console.WriteLine($"3) rb.ID={rb.Id}");

            // convert back ...
            // what is legal and why?

            // as results in null
            B rb0 = ra as B;
            Console.WriteLine($"4) rb0={rb0}");
            // direct cast fails instead
            // B rb1 = (B)ra;
            // Console.WriteLine($"5) rb1={rb1}");

            B rb2 = rb as B;
            Console.WriteLine($"6) rb2.Num={rb2.Num}");
            B rb3 = (B) rb;
            Console.WriteLine($"7) rb3.Num{rb3.Num}");

            // Stackov.: With the "classic" method, if the cast fails, an exception is thrown. 
            // With the as method, it results in null, which can be checked for, and 
            // avoid an exception being thrown.
        }

        class A
        {
            public A()
            {
                Id = -1;
            }

            public A(int id)
            {
                Id = id;
            }

            public int Id { get; set; }
        }

        class B : A // only one class possible
        {
            public B()
            {
                Num = -2;
            }

            public B(int id) : base(id)
            {
                Num = -3;
            }

            public int Num { get; set; }
        }
    }
}