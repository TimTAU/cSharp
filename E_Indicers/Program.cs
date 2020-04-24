using System;

namespace E_Indicers
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D v = new Vector2D(1, 2);
            v[1] = 12;
            Console.WriteLine($"1) v={v} v[0]={v["0"]}");
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

            // indicer, also possible this[int i, int j] etc
            public int this[string s]
            {
                get { return (s == "0") ? x : y; }
            }

            public int this[int index]
            {
                get { return (index == 0) ? x : y; }

                set
                {
                    if (index == 0) x = value;
                    else y = value;
                }
            }
        }
    }
}