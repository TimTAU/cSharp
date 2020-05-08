using System;
using System.Collections.Generic;

namespace A_Types_01_Overview {
    class Program {
        static void Main(string[] args) {
            int n1 = 42;
            Console.WriteLine("01) Type of n1: " + n1.GetType().Name);

            System.Int32 n2 = 127;
            Console.WriteLine("02) Type of n2: " + n2.GetType().Name);

            Type t = n1.GetType();
            WriteTypeInfo(t);

            WriteTypeInfo(new int[5].GetType());

            WriteTypeInfo(new A().GetType());
            WriteTypeInfo(new B().GetType());
            WriteTypeInfo(new S().GetType());

            WriteTypeInfo(new List<string>().GetType());
        }

        /// <summary>
        /// sample classes to show type information
        /// </summary>
        class A { }

        class B : A { }

        struct S { }

        /// <summary>
        /// helper function, writes some type properties
        /// </summary>
        static void WriteTypeInfo(Type t) {
            Console.WriteLine(
                "03) name=" + t.Name + "\n" +
                "    module=" + t.Module + "\n" +
                "    namespace=" + t.Namespace + "\n" +
                "    basetype=" + t.BaseType.Name + "\n" +
                "    value?=" + t.IsValueType +
                ", generic?=" + t.IsGenericType +
                ", array?=" + t.IsArray
            );
        }
    }
}