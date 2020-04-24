using System;
using System.Collections.Generic;

namespace A3_Cuetiva
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Kontakt> kontakts = new List<Kontakt>(new Kontakt[] {new Kunde("Karl", new List<string>(), 3000), new Lieferant("Lieferando", new List<string>(), "Sparkasse")});
            foreach (var kontakt in kontakts)
            {
                Console.WriteLine(kontakt.MonatsReport());
            }
        }
    }

    abstract class Kontakt : IReport
    {
        private string Name { get; }

        private List<string> EMails { get; }

        protected Kontakt(string name, List<string> eMails)
        {
            Name = name;
            EMails = eMails;
        }
        public abstract string MonatsReport();
    }

    interface IReport
    {
        public string MonatsReport();
    }

    class Kunde : Kontakt
    {
        public Kunde(string name, List<string> eMails, int kontostand) : base(name, eMails)
        {
            Kontostand = kontostand;
        }

        private double Kontostand { get; }
        public override string MonatsReport()
        {
            return Kontostand.ToString();
        }
    }

    class Lieferant : Kontakt
    {
        public Lieferant(string name, List<string> eMails, string bankverbindung) : base(name, eMails)
        {
            Bankverbindung = bankverbindung;
        }

        private string Bankverbindung { get; }
        public override string MonatsReport()
        {
            return Bankverbindung;
        }
    }
}