// a.voss@fh-aachen.de
//
// Verwendung von "value types" und "reference types".
//

using System;

namespace I_ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // define to class-points
            Point_C pc1 = new Point_C { x = 11, y = 15 }, pc2;

            // what happens?
            pc2 = pc1;
            Console.WriteLine("C1) pc1: " + pc1);
            Console.WriteLine("C1) pc2: " + pc2 + "\n");

            // what changes?
            pc2.x = 16;
            Console.WriteLine("C2) pc1: " + pc1);
            Console.WriteLine("C2) pc2: " + pc2 + "\n");

            // and now?
            setx(pc2, 17);
            Console.WriteLine("C3) pc1: " + pc1);
            Console.WriteLine("C3) pc2: " + pc2 + "\n");

            // define two struct points
            Point_S ps1 = new Point_S { x = 21, y = 25 }, ps2;

            // what happens?
            ps2 = ps1;
            Console.WriteLine("S1) ps1: " + ps1);
            Console.WriteLine("S1) ps2: " + ps2 + "\n");

            // what changes?
            ps2.x = 22;
            Console.WriteLine("S2) ps1: " + ps1);
            Console.WriteLine("S2) ps2: " + ps2 + "\n");

            // and now?
            setx(ref ps2, 23);
            Console.WriteLine("S3) ps1: " + ps1);
            Console.WriteLine("S3) ps2: " + ps2 + "\n");
        }
        
        /// <summary>
        /// a sample reference type - a class
        /// </summary>
        class Point_C
        {
            public int x, y;

            public override string ToString()
            {
                return string.Format("x={0}; y={1}", this.x, this.y);
            }
        }

        /// <summary>
        /// a sample value type - a struct
        /// </summary>
        struct Point_S
        {
            public int x, y;

            public override string ToString()
            {
                return string.Format("x={0}; y={1}", this.x, this.y);
            }
        }

        /// <summary>
        /// some "global" function taking Point-classes and structs (overload)
        /// </summary>
        static void setx(Point_C pt, int x) { pt.x = x; }
        static void setx(ref Point_S pt, int x) { pt.x = x; }

    }
}
