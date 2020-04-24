// a.voss@fh-aachen.de
//
// Einfache Art, von der Console einzulesen (parse).
// Formatierte Ausgabe.
//

using System;

namespace C_Console_IO_Extended
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1) Bitte Eingabe Text: ");
            string line = Console.ReadLine();
            Console.WriteLine("2) Sie haben eingegeben: '" + line + "'");

            Console.Write("3) Bitte Eingabe Zahl: ");
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine("4) Sie haben eingegeben: '" + num + "'");
            
            int n = 23, m = 42;
            Console.WriteLine("5) Ausgabe: '{0:d}', '{1,4:d}', '{1,-4:d}', '{1,4:####}', '{1,4:0000}'", n, m);

            // same result
            string format = string.Format("   Ausgabe: '{0:d}', '{1,4:d}', '{1,-4:d}', '{1,4:####}', '{1,4:0000}'", n, m);
            Console.WriteLine(format);

            // string interpolation, note the $ and no additional parameters
            Console.WriteLine($"   Ausgabe: '{n}', '{m,4}', '{m,-4}', '{m,4:####}', '{m,4:0000}'");

            n = 0x1234;
            Console.WriteLine("6) Ausgabe: '{0:x4}'", n);                      // hex
            Console.WriteLine($"   Ausgabe: '{n:x4}'");                      // hex

            double d = 1.2345678;
            Console.WriteLine("7) Ausgabe: '{0:f}', '{0:e}', {0:#.####}", d);  // gerundet
            Console.WriteLine($"   Ausgabe: '{d:f}', '{d:e}', {d:#.####}");  // gerundet

            string s = "Text";
            Console.WriteLine("8) Ausgabe: '{0,10}', '{0,-10}'", s);
            Console.WriteLine($"   Ausgabe: '{s,10}', '{s,-10}'");

            n = -10;
            Console.WriteLine($"9) Berechnung, Ergebnis: {Math.Abs(4*10-2)}");
        }
    }
}