using System;
using System.Collections.Generic;

namespace H_TypeConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            EmplList<EmployeeEurope> l = new EmplList<EmployeeEurope>();

            l.Add(new EmployeeEurope() { Name = "def", ID=1 });
            l.Add(new EmployeeEurope() { Name = "abc", ID=2 });

            Console.WriteLine("1) vor Sort");
            foreach (var e in l)
                Console.WriteLine($"2)   Name: {e.Name}");
            l.MySort();
            Console.WriteLine("3) nach Sort");
            foreach (var e in l)
                Console.WriteLine($"4)   Name: {e.Name}");

            // details see http://msdn.microsoft.com/en-us/library/d5x73970.aspx
        }

        public class EmplList<T> : List<T> where T:Employee
        {
            public void MySort()
            {
                this.Sort((a, b) => a.Name.CompareTo(b.Name));
            }
        }

        public class Employee
        {
            public string Name
            {
                get;
                set;
            }
        }

        public class EmployeeEurope : Employee
        {
            public int ID
            {
                get;
                set;
            }
        }

    }
}