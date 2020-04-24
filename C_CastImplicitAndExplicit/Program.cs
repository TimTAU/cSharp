using System;

namespace C_CastImplicitAndExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D v;
            // implicit case
            // v = 10;
            // explicit case
            v = (Vector2D) 12;
            Console.WriteLine($"1) v={v}");


            // implicit case
            A a1 = new A(2.0);
            double d = a1;
            bool b = (12.2 == a1); // Achtung!
            Console.WriteLine($"2) a1.d={a1.d}");
            A a2 = 23;
            Console.WriteLine($"3) a2.d={a2.d}");


            // explicit case
            B b1 = new B(3.0);
            double e = (double) b1;
            // bool b = (12.2 == b1);
            Console.WriteLine($"4) b1.d={b1.d}");
            B b2 = (B) 24;
            Console.WriteLine($"5) b2.d={b2.d}");
        }

        class A
        {
            public double d;

            public A(double d)
            {
                this.d = d;
            }

            public static implicit operator double(A a)
            {
                return a.d;
            } // kein Datenverlust zu befürchten

            public static implicit operator A(double d)
            {
                return new A(d);
            }
        }

        class B
        {
            public double d;

            public B(double d)
            {
                this.d = d;
            }

            public static explicit operator double(B b)
            {
                return b.d;
            }

            public static explicit operator B(double d)
            {
                return new B(d);
            }
        }

        /// <summary>
        /// s sample class for explicit, implicit, indexer etc
        /// </summary>
        class Vector2D
        {
            private int x, y;

            public Vector2D(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return "(" + this.x + ";" + this.y + ")";
            }

            public static explicit operator Vector2D(int n)
            {
                return new Vector2D(n, n);
            }

            /*public static implicit operator Vector2D(int n)
            {
                return new Vector2D(n, n);
            }*/
        }
    }
}