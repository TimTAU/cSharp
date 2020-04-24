// a.voss@fh-aachen.de
//
// Verwendung des IDisposal Interfaces mit using.
//

using System;

namespace F_UsingAndDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * problem: destructors are called according to garbage collection
             * i.e. time is unknown and resources need to be freed earlier
             * -> use dispose interface
             * -> there is a pattern for dispose with managed and unmanaged resources, see MSDN
             * -> for "using" the sample above is sufficient
             */

            using (UseMe u1 = new UseMe())
            {
                // work with u1
                u1.f();
                // at the end Dispose is called
            }

            {
                UseMe u2 = new UseMe();
                //u2.Dispose();
            }
        }
    }
    
    /// <summary>
    /// class with disposal-interface, for interfaces see function below
    /// </summary>
    class UseMe : IDisposable
    {
        public UseMe() { Console.WriteLine("1) UseMe.ctor"); }
        
        public void f() { Console.WriteLine("2) UseMe.f()"); }
        
        public void Dispose() { Console.WriteLine("3) UseMe.Dispose"); }
    }

}