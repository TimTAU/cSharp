// a.voss@fh-aachen.de
//
// Lesen und Schreiben von Textdateien mit und ohne Streams.
//

using System;
using System.IO;

namespace D_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../../bundesliga";

            // short version

            string[] lines = File.ReadAllLines(fileName + "-0.txt");

            Console.WriteLine("1) Bundesliga - clubs");
            foreach (string line in lines)
                Console.WriteLine("   line: " + line.Substring(0, 26));

            // cut lines
            for (int i = 0; i < lines.Length; ++i)
                lines[i] = lines[i].Substring(0, 26);

            File.WriteAllLines(fileName + "-1.txt", lines);

            // stream version

            StreamReader reader = new StreamReader(fileName + "-1.txt");

            // read first 5 lines, not optimal

            string[] headlines = new string[5];
            string oneline;
            int pos = 0;

            oneline = reader.ReadLine();          // null if eof
            while (oneline != null && pos < 5)
            {
                headlines[pos] = oneline;
                ++pos;

                oneline = reader.ReadLine();
            }
            reader.Close();     // frees handles etc.

            // write modified lines but with better technique -> using keyword
            StreamWriter writer = new StreamWriter(fileName + "-2.txt");
            using (writer)  // 
            {
                
                foreach (string headline in headlines)
                {
                    writer.WriteLine("club: " + headline);
                }
                //writer.Close(); is not necessary
            }

        }
    }
}