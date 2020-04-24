// a.voss@fh-aachen.de
//
// Verwendung abstrakter Klassen und Interfaces.
//

using System;
using System.Collections.Generic;

namespace H_AbstractClassesAndInterfaces
{
    /// - general rules, a quote from "The Complete Reference C# 2.0" by Herbert Schildt:
    ///     "When you can fully describe the concept in terms of "what it does" without needing to 
    ///     specify any of "how it does it", then you should use an interface.  
    ///     If you need to include some implementation details, then you will need to represent 
    ///     your concept in an abstract class."
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new BMW(250);
            Car car2 = new VW(120);
            
            List<Car> list = new List<Car> { car1, car2 };
            foreach (Car current in list)
            {
                current.drive();
            }

            IDriveable mobile = new Bobbycar();
            mobile.drive();
        }
    }
    
        /// <summary>
        /// sample abstract and non-abstract classes
        /// </summary>
        abstract class Car
        {
            private int speed;
            public int Speed
            {
                get { return this.speed; }
                set { this.speed = (value > 0) ? value : 0; }
            }

            protected Car(int v) { this.Speed = v; }

            public abstract void drive();
        }

        class BMW : Car
        {
            public BMW(int v) : base(v) { }

            public override void drive()
            {
                Console.WriteLine("drive a BMW!");
            }
        }

        class VW : Car
        {
            public VW(int v) : base(v) { }

            public override void drive()
            {
                Console.WriteLine("drive a VW!");
            }
        }

        /// <summary>
        /// sample interface and implementation
        /// </summary>
        interface IDriveable
        {
            void drive();
        }

        class Bobbycar : IDriveable
        {
            public void drive()
            {
                Console.WriteLine("drive a Bobbycar!");
            }
        }

        /*
         *  Interface
             * Alle Members müssen implementiert werden (Interface Members sind standardmässig abstract).
             * Enthalten nur öffentliche Members.
             * Eine Klasse kann mehrere Interfaces implementieren (Polymorphie über verschiedene Klassen (Hierarchien).
             * Beschreiben einen Vertrag / Abmachung.
             * Ein Interface ist nicht veränderbar, bei einer Veränderung bricht der ganze Clientcode, da dieser komplett angepasst werden müsste [Versioning Issues With Abstract Base Classes and Interfaces].
             * Beschreibt eine has-a (hat ein) Beziehung.
             * Kann nicht instanziiert werden (Nur Benutzung des Types selber). 

            Abstrakte Klassen
             * Kann schon Implementation enthalten.
             * Zwang zur Implementation für die erbende Klasse per abstract-Schlüsselwort möglich.
             * Optionale Implementation für die erbende Klasse per virtual-Schlüsselwort möglich.
             * Nur Einfachvererbung möglich.
             * Beschreiben einen Vertrag / Abmachung.
             * Die abstrakte Klasse ist veränderbar, jedoch nur zu einem gewissen Grad und auch 
             * umständlich [Abstract Base Classes Have Versioning Problems Too].
             * Beschreibt eine is-a (ist ein) Beziehung
             * Kann nicht instanziiert werden (Nur Benutzung des Types selber). 
         */

}
