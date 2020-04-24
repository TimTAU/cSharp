// a.voss@fh-aachen.de
//
// Beispiel einer einfachen Klassendefinition und Objekterzeugung.
//

using System;
using System.Collections.Generic;

namespace E_Objects2
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new Person();
            Console.WriteLine("1) "+o.ToString());

            // use std constructor
            Person person1 = new Person();
            Console.WriteLine("2) Name = " + person1.Name + ", length = " + person1.getNameLength());

            // use qualified class name, same as above
            Person person2 = new Person();
            person2.Name = "Bodo";      // sets name via setter
            Console.WriteLine("3) "+person2); // calls ToString

            // initialises object in one step
            Person person3 = new Person { Name = "Klaus" };
            Console.WriteLine("4) "+person3);

            Console.WriteLine("5) list of persons:");
            List<Person> list = new List<Person> { person1, person2, person3 };
            foreach (var person in list)
            {
                Console.WriteLine("   "+person);
            }

        }
    }
    
    /// <summary>
    /// a sample class
    /// </summary>
    class Person
    {
        public string s;
        protected double d;

        // public private protected internal
        private string name;

        // property
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        // public string Name { get; set; }

        // public int ID;
        // short definition
        /// <summary>
        ///  my ID
        /// </summary>
        public int ID { get; set; }

        // ctor
        public Person()
        {
            this.Name = "N.N.";
        }

        public int getNameLength()
        {
            return (this.Name != null) ? this.Name.Length : 0;
        }

        // override!
        public override String ToString()
        {
            //base.ToString();
            return string.Format("Name reads {0}, length {1}.", this.Name, this.getNameLength());
        }
    }

}
