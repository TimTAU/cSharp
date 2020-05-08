using System;

namespace A_Types_02_Reflection {
    class Program {
        static void Main(string[] args) {
            // type information of a D-object
            Type t = new D().GetType();
            WriteTypeInfo(t);

            // all class member, i.e. variables (fields), properties, methods
            foreach (var x in t.GetMembers()) {
                Console.WriteLine("02) memberinfo: " + x + ", " + x.MemberType);
            }

            foreach (var p in t.GetProperties()) {
                Console.WriteLine("03) prop.info: " + p + ", " + p.Name);
            }

            // all methods including parameter info
            foreach (var y in t.GetMethods()) {
                Console.Write("04) methodinfo: " + y);
                foreach (var m in y.GetParameters())
                    Console.Write(" " + m);
                Console.WriteLine();
            }

            // all interfaces
            foreach (var z in t.GetInterfaces()) {
                Console.WriteLine("05) interfaceinfo: " + z + ", " + z.Name);
            }

            // call a method by name
            D d = new D{n = 42}; // d.g(2)
            t = d.GetType();
            var f = t.GetMethod("g");
            // if (f!=null) f.Invoke(d, new object[] {2});
            f?.Invoke(d, new object[] {2});
        }

        /// <summary>
        /// helper function, writes some type properties
        /// </summary>
        static void WriteTypeInfo(Type t) {
            Console.WriteLine(
                "01) name=" + t.Name + "\n" +
                "    module=" + t.Module + "\n" +
                "    namespace=" + t.Namespace + "\n" +
                "    basetype=" + t.BaseType.Name + "\n" +
                "    value?=" + t.IsValueType +
                ", generic?=" + t.IsGenericType +
                ", array?=" + t.IsArray
            );
        }

        /// <summary>
        /// sample interface and class to show class-members
        /// </summary>
        interface I {
            void g(int m);
        }

        class D : I {
            public int n;
            private string s;

            public string S {
                get { return this.s; }
                set { this.s = value; }
            }

            public int f1() { return 0; }
            private void f2(int n) { return; }
            static string f3(string s) { return s; }

            public void g(int m) { Console.WriteLine("in D:g() n*m=" + (n * m)); }
        }
    }
}