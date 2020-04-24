// a.voss@fh-aachen.de
//
// Ein einfaches C# Programm - erklärt.
//
using System;

// namespaces:
//  - gruppiert einzelne Elemente, Klassen etc.
//  - .NET enthält eine Reihe namespaces, z.B. Math etc.
//  - kann geschachtelt werden
namespace B_HelloWorld_Explained
{
    /// <summary>
    /// - main class, Startpunkt des Programms (static Main function)
    /// </summary>
    class Program
    {
        /// <summary>
        /// - Startpunkt des Programm
        /// - siehe Projekteinstellungen / project settings
        /// - alle Beispiele werden so generiert
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}