// a.voss@fh-aachen.de
//
// Verwendung und Sinn virtueller Funktionen.
//

using System;

namespace G_VirtualAndOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(12);
            B b = new B();
            A a2 = new B();
            
            a.M1();
            a.M2();
            b.M1();
            b.M2();
            a2.M1();
            a2.M2();
        }
    }
    
    /// <summary>
    /// a sample class for inheritance
    /// </summary>
    class A
    {
        private int n;

        // constructor (cstr) with argument, note "this"
        public A(int n) { this.n = n; }

        public void M1() { Console.WriteLine("A.M1"); }
        public virtual void M2() { Console.WriteLine("A.M2"); }
    }

    /// <summary>
    /// a sample sub-class 
    /// </summary>
    class B : A
    {
        // constructor w.o. arguments, calling base class cstr
        public B() : base(5) { }

        public new void M1() { Console.WriteLine("B.M1"); }
        
        public override void M2() { Console.WriteLine("B.M2"); }
    }

}