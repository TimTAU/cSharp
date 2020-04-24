using System;
using System.Collections.Generic;
using System.Text;

namespace A3_Caros
{
    class Program
    {
        static void Main(string[] args)
        {
            Tier t = new Elefant("Benjamin", Int32.MaxValue);
            Tier t1 = new Zikade("Jeremy", 4);

            Zoo zoo = new Zoo();
            zoo += t;
            zoo += t1;

            Console.WriteLine(zoo);
        }
    }

    class Tier
    {
        public string Name { get; set; }

        protected Tier(string name)
        {
            Name = name;
        }
    }

    class Elefant : Tier
    {
        public Elefant(string name, int ruessellaenge) : base(name)
        {
            Ruessellaenge = ruessellaenge;
        }

        private int Ruessellaenge { get; set; }

        public override string ToString()
        {
            return $"{Name}'s Rüssel ist {Ruessellaenge} lang.";
        }
    }

    class Zikade : Tier
    {
        public Zikade(string name, int fluegel) : base(name)
        {
            Fluegel = fluegel;
        }

        private int Fluegel { get; set; }

        public override string ToString()
        {
            return $"{Name} hat {Fluegel} Flügel.";
        }
    }

    class Zoo
    {
        private List<Tier> Tiere { get; }

        public Zoo()
        {
            Tiere = new List<Tier>();
        }

        public static Zoo operator +(Zoo zoo, Tier tier)
        {
            zoo.Tiere.Add(tier);
            return zoo;
        }

        public override string ToString()
        {
            StringBuilder ret = new StringBuilder("");
            foreach (var tier in Tiere)
            {
                ret.Append(tier + "\n");
            }

            return ret.ToString();
        }
    }
}