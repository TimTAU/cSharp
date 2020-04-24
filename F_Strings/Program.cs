using System;

namespace F_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant original string
            // note, that all functions return a copy
            const string original = "Hallo 12345 Ende";
            Console.WriteLine("Original:          '" + original + "'");

            string sStart;
            int pos;
            bool b;

            // contains some text?
            b = original.Contains("Ende");
            Console.WriteLine("enthält 'Ende':    '" + b + "'");

            // looks for position of some text
            pos = original.IndexOf('0');                        // -1
            Console.WriteLine("indexof '0':       '" + pos + "'");
            pos = original.IndexOf('1');                        // 6
            Console.WriteLine("indexof '1':       '" + pos + "'");

            // extracts text 
            sStart = original.Substring(pos);
            Console.WriteLine("substr ab '1':     '" + sStart + "'");
            sStart = original.Substring(pos, 5);                     // start, len
            Console.WriteLine("substr '1'-'5':    '" + sStart + "'");

            // replaces text
            sStart = original.Replace("l", "L");                    // replace all
            Console.WriteLine("substr 'l'->'L':   '" + sStart + "'");

            // converts to lower or upper case
            sStart = original.ToLower();
            Console.WriteLine("lower:             '" + sStart + "'");
            sStart = original.ToUpper();
            Console.WriteLine("upper:             '" + sStart + "'");

            // inserts or removes text 
            sStart = original.Insert(5, "!");
            Console.WriteLine("insert '!':        '" + sStart + "'");
            sStart = original.Remove(7, 3);                         // start, len
            Console.WriteLine("remove '2'-'4':    '" + sStart + "'");

            // removes white space
            sStart = original.Trim();
            Console.WriteLine("trim:              '" + sStart + "'");

            // use escape-seq.
            sStart = "\\123\\456\t789";
            Console.WriteLine("Esc-Seq.:          '" + sStart + "'");
            // use as it is given
            sStart = @"\123\456\t789";
            Console.WriteLine("Esc-Seq.:          '" + sStart + "'");

            // splits text, assigns array elements []
            string[] a = original.Split(' ');
            Console.WriteLine("split to array: Länge: " + a.Length + ", '" + a[0] + "', '" + a[1] + "', '" + a[2] + "'");
        }
    }
}
