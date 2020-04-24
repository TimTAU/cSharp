using System;

namespace J_ConditionalsIfSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12, m;

            // short but error prone due to missing braces -> usually do not use it this way 
            if (n > 10)
                m = 1;
            else
                m = 2;

            // now you can add some code safely
            if (n > 10)
            {
                m = 1;
            }
            else
            {
                m = 2;
            }

            // attention: assignment inside if-clause -> usually do not use it 
            //m = n++ * 2;
            if ((m = n++ * 2) > 25)
                m = 1;
            else
                m = 2;

            Console.WriteLine("n=" + n + ", m=" + m);

            // some way to organize different short case (exception of cases above)
            if (n > 10)
                m = 1;
            else if (n > 5)
                m = 2;
            else if (n > 1)
                m = 3;
            else
                m = 4;

            // a better way
            switch (m)
            {
                case 1:
                    Console.WriteLine("case m=1");
                    break;
                case 2:
                    Console.WriteLine("case m=2");
                    break;
                case 3:
                case 4:     // both cases
                    Console.WriteLine("case m=3 oder 4");
                    break;
                case 5:
                    int nLocal = 12;    // a local variable
                    Console.WriteLine("case m=5 " + nLocal);
                    break;
                default:                // optional
                    Console.WriteLine("def. m=?");
                    break;
            }

            // switch works for strings as well
            string s = "Oops";
            switch (s)
            {
                case "Oops":
                    Console.WriteLine("case Oops");
                    break;
                default:
                    Console.WriteLine("def. ????");
                    break;
            }

            //double d = 251.0;
            double d = 2.51 * 100;
            switch (d)
            {
                case 251.0:
                    Console.WriteLine("double ????");
                    break;
            }
        }
    }
}
