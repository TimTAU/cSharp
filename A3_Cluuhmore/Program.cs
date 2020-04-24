using System;

namespace A3_Cluuhmore
{
    class Program
    {
        static void Main(string[] args)
        {
            Komplex k = new Komplex(3, 4);
            Console.WriteLine(k);
            
            Console.WriteLine(k[0]);
            k[0] = 7;
            Console.WriteLine(k);
        }
    }

    class Komplex : IComparable
    {
        public Komplex(int real, int img)
        {
            Real = real;
            Img = img;
        }

        private int Real { get; set; }
        private int Img { get; set; }

        public static Komplex operator +(Komplex k1, Komplex k2)
        {
            return new Komplex(k1.Real + k2.Real, k1.Img + k2.Img);
        }
        
        public static Komplex operator -(Komplex k1, Komplex k2)
        {
            return new Komplex(k1.Real - k2.Real, k1.Img - k2.Img);
        }

        public static bool operator ==(Komplex k1, Komplex k2)
        {
            // ReSharper disable once PossibleNullReferenceException
            return k1.Real == k2.Real && k1.Img == k2.Img;
        }

        public static bool operator !=(Komplex k1, Komplex k2)
        {
            return !(k1 == k2);
        }

        public override string ToString()
        {
            return $"{Real} {Img}i";
        }

        public int CompareTo(object obj)
        {
            if (obj is Komplex)
            {
                return CompareTo((Komplex) obj);
            }
            throw new Exception("Don't compare Komplex object with non Komplex object");
        }


        public int CompareTo(Komplex k)
        {
            return this == k ? 0 : 1;
        }

        public int this[int index]
        {
            // Lange Schreibweise
            /*get
            {
                return (i == 0) ? Real : Img;
            }*/
            // Kurze Schreibweise
            get => index == 0 ? Real : Img;


            set
            {
                if (index == 0)
                {
                    Real = value;
                }
                else
                {
                    Img = value;
                }
            }
        }
    }
}