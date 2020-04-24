using System;

namespace D_Operators
{
    // see also: https://msdn.microsoft.com/de-de/library/ms173147(v=vs.90).aspx

    class Program
    {
        static void Main(string[] args)
        {
            Vector2D v1 = new Vector2D(1, 2), v2 = new Vector2D(3, 4);
            Console.WriteLine($"1) v1={v1}, v2={v2}");

            Vector2D v3 = v1 + v2 * 3;
            Console.WriteLine($"2) v3={v3}");

            //v3 += v1;
            //v3 = v3 + v1;

            Vector2D v4 = new Vector2D(v3.x, v3.y);
            bool b;

            b = (v3 == v4);
            Console.WriteLine($"3) b = {b}");

            b = (v3.CompareTo(v4) == 0);
            Console.WriteLine($"4) b = {b}");

            //b = (v3.CompareTo(b) == 0);
            //Console.WriteLine("b = " + b);
        }

        /// <summary>
        /// s sample class for ops
        /// note:  [], (), op? not possible to overload
        /// </summary>
        class Vector2D : IComparable
        {
            public int x, y;

            public Vector2D(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static Vector2D operator +(Vector2D a, Vector2D b)
            {
                return new Vector2D(a.x + b.x, a.y + b.y);
            }

            public static Vector2D operator *(int a, Vector2D b)
            {
                return new Vector2D(a * b.x, a * b.y);
            }

            public static Vector2D operator *(Vector2D b, int a)
            {
                return a * b;
            }

            public override string ToString()
            {
                return $"({this.x};{this.y})";
            }

            // static constructor, is called at the very first beginning
            static Vector2D()
            {
                Console.WriteLine("this is the first line");
            }

            public static bool operator ==(Vector2D a, Vector2D b)
            {
                return (a.x == b.x && a.y == b.y);
            }

            public static bool operator !=(Vector2D a, Vector2D b)
            {
                return !(a == b);
            }

            public int CompareTo(object obj)
            {
                Vector2D v = obj as Vector2D;
                return (x == v.x && y == v.y) ? 0 : 1;
                //throw new NotImplementedException();
            }
        }
    }
}