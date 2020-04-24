// a.voss@fh-aachen.de
//
// Verwendung von Ausnahmen (exceptions).
//

using System;

namespace A_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = null;        // no object given!

            try
            {
                o.ToString();       // throws!
            }
            catch
            {
                Console.WriteLine("1) all exceptions caught");
            }

            try
            {
                throw new IndexOutOfRangeException("oops, wrong index");
            }
            catch (Exception e)
            {
                Console.WriteLine("2) exception reason: " + e.Message);
            }

            try
            {
                o.ToString();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("3) Null Ref.: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("4) exception reason: " + e);
            }
            finally
            {
                Console.WriteLine("5) in finally");
            }
            Console.WriteLine();        
        }
    }
}