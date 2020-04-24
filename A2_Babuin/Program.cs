using System;

namespace A2_Babuin
{
    class Program
    {
        static void Main(string[] args)
        {
            var contactEmpty = new Contact();
            var contact = new Contact("Peter", 50);
            Console.WriteLine(contactEmpty);
            Console.WriteLine(contact);
        }
    }

    class Contact
    {
        //Short way
        private string Name { get; set; }

        //Long way
        private int _alter;

        // ReSharper disable once ConvertToAutoProperty
        private int Alter
        {
            get => _alter;
            set => _alter = value;
        }


        public Contact()
        {
            Name = "n.n";
        }

        public Contact(string name, int alter)
        {
            Name = name;
            Alter = alter;
        }

        public override string ToString()
        {
            return $"{Name} ist {Alter} Jahre alt.";
        }
    }
}