using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A2_Boudadillo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var lines = File.ReadAllLines("../../../bundesliga-0.txt");
            File.WriteAllLines("../../../bundesliga-1.txt", lines.Reverse());

            lines = File.ReadAllLines("../../../bundesliga-0.txt");
            Tabelle tabelle = new Tabelle();
            foreach (var row in lines)
            {
                Verein verein = new Verein(row.Substring(0, 26).Trim());
                tabelle.Verein.Add(verein);
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string[] spiele = lines[i].Substring(26, lines[i].Length - 27).Split(" ");
                for (int j = 0; j < spiele.Length; j++)
                {
                    string[] tore = spiele[j].Split(":");
                    if (tore.Length != 2)
                    {
                        break;
                    }

                    int eins = int.Parse(tore[0]);
                    int zwei = int.Parse(tore[1]);
                    if (eins > zwei)
                    {
                        tabelle.Verein[i].Punkte += 3;
                    }
                    else if (eins < zwei)
                    {
                        tabelle.Verein[j].Punkte += 3;
                    }
                    else
                    {
                        tabelle.Verein[i].Punkte += 1;
                        tabelle.Verein[j].Punkte += 1;
                    }

                    tabelle.Verein[i].Tore += eins;
                    tabelle.Verein[j].Tore += zwei;
                }
            }

            Console.WriteLine(tabelle);
        }
    }

    class Verein
    {
        private string Name { get; set; }

        public int Tore { get; set; }

        public int Punkte { get; set; }

        public Verein(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} hat {Tore} Tore geschossen und damit {Punkte} erzielt.";
        }
    }

    class Tabelle
    {
        public List<Verein> Verein { get; set; }

        public Tabelle()
        {
            Verein = new List<Verein>();
        }

        public override string ToString()
        {
            var ret = "";
            foreach (var verein in Verein)
            {
                ret += verein + Environment.NewLine;
            }

            return ret;
        }
    }
}