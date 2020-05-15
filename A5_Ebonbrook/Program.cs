using System;
using System.IO;
using System.Linq;

namespace A5_Ebonbrook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../simple.xml");
            
            var waffles = lines.Select(line => line.Split('<', '>'))
                .Where(s=>s.Length>3 && "/"+s[1]==s[^2] && s[2].Contains("Waffle"))
                .Select(s=>s[2]);
            Console.WriteLine("01) Waffles: " + String.Join(",", waffles));
        }
    }
}