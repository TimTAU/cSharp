// a.voss@fh-aachen.de
//
// Gesammelte Übungen 0x03
//

using System;
using System.Collections.Generic;

namespace Z_Uebungen
{
    class Program
    {
        static void Main(string[] args)
        {
            Cluuhmore();
            // Chillmond: vollkommen analog zu Cluuhmore
            Cuetiva();
            Caros();
            // Catoria: in Castecete T mit 'int' ersetzen
            Castecete();
        }

        static void Cluuhmore()
        {
            Console.WriteLine("Cluuhmore");
            Komplex ci = new Komplex(0.0, 1.0);
            Komplex cone = new Komplex(1.0, 0.0);
            Komplex ione = ci + cone;
            Console.WriteLine($"  cmp {ione == new Komplex(1.0, 1.0)}");
        }
        
        class Komplex : IComparable
        {
            public Komplex(double Re, double Im)
            {
                this.Re = Re;
                this.Im = Im;
            }

            public double Re { get; set; }
            public double Im { get; set; }

            public double this[int index]
            {
                get { return (index == 0) ? Re : Im; }

                set
                {
                    if (index == 0) Re = value;
                    else Im = value;
                }
            }
            
            // exemplarisch...
            public static Komplex operator +(Komplex lhs, Komplex rhs)
            {
                return new Komplex(lhs.Re+rhs.Re,lhs.Im+rhs.Im);
            }

            public override string ToString()
            {
                return $"({this.Re};{this.Im})";
            }
            
            public static bool operator ==(Komplex lhs, Komplex rhs)
            {
                return (Math.Abs(lhs.Re-rhs.Re)<1e-14 && Math.Abs(lhs.Im-rhs.Im)<1e-14);
            }

            public static bool operator !=(Komplex lhs, Komplex rhs)
            {
                return !(lhs == rhs);
            }

            public int CompareTo(object obj)
            {
                var c = obj as Komplex;
                return (this==c) ? 0 : 1;
            }
        }
        
        static void Cuetiva()
        {
            Console.WriteLine("Cuetiva");
            Kunde bert = new Kunde { Name="Bert", EMails = new List<string>{"bert@b.com"}, Kontostand = 1234.56m };
            Lieferant shop = new Lieferant { Name="Shop", EMails = new List<string> {"info@shop.com"}, Konto = "Sparkasse" };
            
            var list = new List<Kontakt> { bert, shop };
            foreach (var kontakt in list)
            {
                kontakt.MonatsReport();
            }
        }

        abstract class Kontakt : IReport
        {
            public string Name { get; set; }
            public List<string> EMails { get; set; }
            public abstract void MonatsReport();
            public override string ToString()
            {
                return $"Name {Name}, EMails {string.Join(",",EMails)}";
            }
        }

        interface IReport
        {
            void MonatsReport();
        }

        class Kunde : Kontakt
        {
            public decimal Kontostand { get; set; }
            public override void MonatsReport()
            {
                Console.WriteLine($"  Kunde: {this}, Kontostand {Kontostand}");
            }
        }
        
        class Lieferant : Kontakt
        {
            public string Konto { get; set; }
            public override void MonatsReport()
            {
                Console.WriteLine($"  Lieferant: {this}, Kontonr. {Konto}");
            }
        }

        static void Caros()
        {
            Console.WriteLine("Caros");
            Tier clemens = new Loewe {Name = "Clemens", HatMähne = true };
            Tier gwaihir = new Vogel {Name = "Gwaihir", HatFedern = true };
            
            Console.WriteLine($"  Tier: {clemens}");
            Console.WriteLine($"  Tier: {gwaihir}");
            
            var zoo = new Zoo();
            zoo += clemens;
            zoo += gwaihir;
            
            Console.WriteLine("Zoo, Stand 1.4.2020");
            foreach (var tier in zoo)
            {
                Console.WriteLine($"  Tier im Zoo: {tier}");
            }

            zoo -= "Bert, der nicht verzeichnet ist";
            Console.WriteLine("Zoo, Stand 10.4.2020");
            foreach (var tier in zoo)
            {
                Console.WriteLine($"  Tier im Zoo: {tier}");
            }
            
            zoo -= "Gwaihir";
            Console.WriteLine("Zoo, Stand 20.4.2020");
            foreach (var tier in zoo)
            {
                Console.WriteLine($"  Tier im Zoo: {tier}");
            }
        }

        class Zoo : List<Tier>
        {
            public static Zoo operator +(Zoo zoo, Tier tier)
            {
                zoo.Add(tier);
                return zoo;
            }
            public static Zoo operator -(Zoo zoo, string name)
            {
                // das ist die schnelle Version über Lamdas (die noch folgen)
                // man kann auch manuell in der Liste suchen und mit RemoveAt löschen
                zoo.Remove(zoo.Find(t => t.Name == name));
                return zoo;
            }
        }

        class Tier
        {
            public String Name { get; set; }
            public override string ToString()
            {
                return $"Name:{Name}";
            }
        }

        class Loewe : Tier
        {
            public bool HatMähne { get; set; }
            public override string ToString()
            {
                return $"{base.ToString()}, HatMähne:{HatMähne}";
            }
        }
        
        class Vogel : Tier
        {
            public bool HatFedern { get; set; }
            public override string ToString()
            {
                return $"{base.ToString()}, HatFedern:{HatFedern}";
            }
        }
        
        static void Castecete()
        {
            Console.WriteLine("Castecete");
            
            Queue<int> queue = new Queue<int>();
            queue.enqueue(11);
            queue.enqueue(12);
            queue.enqueue(13);
            while (queue.Count > 0)
            {
                Console.WriteLine($"1) element: {queue.dequeue()}");
            }
        }

        public class Queue<T>
        {
            private List<T> queue = new List<T>();
            
            public int Count => queue.Count;

            public Queue<T> enqueue(T element)
            {
                queue.Add(element);
                return this;
            } 
            
            public T dequeue()
            {
                if (queue.Count==0)
                    throw new IndexOutOfRangeException();
                T rc = queue[0];
                queue.RemoveAt(0);
                return rc;
            } 
        }
        
    }
}
