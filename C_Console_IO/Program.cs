// a.voss@fh-aachen.de
//
// Ausgabe auf die Console incl. String Interpolation, int, var.
//
using System;

// Nachricht an uns!

namespace C_Console_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ausgabe in Terminal / Console, zuerst ohne und danach mit Zeilenumbruch
            Console.Write("1) Hello "); Console.Write("World!"); Console.Write("\n");
            Console.WriteLine("2) Hello World!");

            #region alles mit n
            // hier wird implizit ToString() genutzt
            int n = 23;
            Console.WriteLine("3) n\t=\t" + n);
            #endregion

            // schonmal vorab, m ist streng typisiert, legt Type aus Analyse der rechten Seite fest (int)
            var m = 42;
            Console.WriteLine($"4) m\t=\t{m}");

            // einfache Eingabe
            Console.Write("5) Eingabe: ");
            string s = Console.ReadLine();
            Console.WriteLine("6) Sie haben eingegeben: '" + s + "'");
        }
    }
}