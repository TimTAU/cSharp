using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace B_LINQ_01_Examples {
    
    internal static class Program {
        
        private static void Main() {
            MethodInfo[] methodInfos = typeof(Program).GetMethods(BindingFlags.Static | BindingFlags.Public);
            foreach (var m in methodInfos)
                if (m.Name.StartsWith("case_"))
                    m.Invoke(null, new object[] { });
        }

        static void Write<T>(string intro, IEnumerable<T> container, Func<T, string> f) {
            Console.Write(intro);
            foreach (var n in container)
                Console.Write(f(n));
            Console.Write("\n");
        }

        public static void case_Teaser() {
            int[] numbers = {1, 2, 3};

            var twice =
                from n in numbers
                select 2 * n;
            Write("00.1) twice: ", twice, n => n.ToString() + " ");

            Dictionary<string, string> d = new Dictionary<string, string> {
                ["a"] = "b", ["M"] = "N", ["Ma"] = "Na", ["P"] = "q"
            };

            var ems =
                from k in d.Keys
                where k.StartsWith("M")
                select k;
            Write("00.2) ems: ", ems, n => n.ToString() + " ");
        }

        public static void case_1() {
            int[] numbers = {1, 2, 3, 4, 5, 6};

            // variante 1
            var evenNums =
                from n in numbers
                where (n % 2) == 0
                select n;
            Write("01.1) even: ", evenNums, n => n.ToString() + " ");

            // variante 2 mit extension methods (obiges wird so übersetzt!)
            // und IEnumerable statt var
            IEnumerable<int> evenEnum = numbers.Where(n => (n % 2) == 0);
            Write("01.2) even: ", evenEnum, n => n.ToString() + " ");

            // wann wird das Where ausgeführt?
            IEnumerable<int> newEvenEnum = numbers.Where(n => (n % 2) == 0);
            //numbers[0] = 10;    // was waere bei: 
            numbers = new int[] {11, 12, 13, 14, 15, 16};
            Write("01.3) even: ", newEvenEnum, n => n.ToString() + " ");
        }


        // select mit orderby
        public static void case_2() {
            int[] numbers = {1, 2, 3, 4, 5, 6};

            // variante 1
            var evenNums =
                from n in numbers
                where (n % 2) == 0
                orderby n descending
                select n;
            Write("02.1) even: ", evenNums, n => n.ToString() + " ");

            // variante 2
            var evenEnum = numbers.Where(n => (n % 2) == 0).OrderByDescending(n => n); // aufsteigend: OrderBy
            Write("02.2) even: ", evenEnum, n => n.ToString() + " ");
        }

        // ohne where
        public static void case_3() {
            int[] numbers = {1, 2, 3, 4, 5, 6};

            // variante 1
            var evenNums =
                from n in numbers
                select 2 * n;
            Write("03.1) even: ", evenNums, n => n.ToString() + " ");

            // variante 2 
            var evenEnum = numbers.Select(n => 2 * n);
            Write("03.2) even: ", evenEnum, n => n.ToString() + " ");
        }

        // mit anonymem Type
        public static void case_4() {
            int[] numbers = {1, 2, 3, 4, 5, 6};

            // variante 1
            var evenNums =
                from n in numbers
                where (n % 2) == 0
                select new {np = n, nm = -n};
            Write("04.1) n,-n: ", evenNums, pair => "(" + pair.np + ":" + pair.nm + ") ");

            // variante 2 
            var evenEnum = numbers.Where(n => (n % 2) == 0).Select(n => new {np = n, nm = -n});
            Write("04.2) n,-n: ", evenEnum, n => n.ToString() + " ");
        }

        // nochmal anonymer Type
        public static void case_5() {
            int[] numbers = {1, 2, 3, 4, 5, 6};

            // variante 1
            var evenNums =
                from n in numbers
                select new {ndiv = n / 3, nmod = n % 3};
            Write("05.1) n/3,n%3: ", evenNums, x => "(" + x.ndiv + ":" + x.nmod + ") ");
        }

        // gemischte collections
        public static void case_6() {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var textNums =
                from n in numbers
                select strings[n];
            Write("06.1) text: ", textNums, s => s + " ");
        }

        // mehrere collections
        public static void case_7() {
            int[] numbers = {1, 2, 3};
            char[] chars = {'A', 'B', 'C'};

            // variante 1
            var pairs1 =
                from c in chars
                from n in numbers
                select c + n.ToString();
            Write("07.1) pairs1: ", pairs1, x => x + " ");

            // variante 2, direkt
            var pairs2 =
                from c in new char[] {'a', 'b'}.Reverse()
                from n in new [] {1, 2, 3}.Reverse()
                select c + n.ToString();
            Write("07.2) pairs2: ", pairs2, x => x + " ");
        }

        // eine Art join
        public static void case_8() {
            int[] numbers = {11, 12, 13};
            char[] chars = {'A', 'B', 'C'};

            var pairs1 =
                from c in chars
                from n in numbers
                where n % 10 == c - 64 // ID1==ID2
                select "(" + (n % 10) + ":" + c + ")";
            Write("08.1) pairs1: ", pairs1, x => x + " ");
        }

        // join mit kleineren Datenmengen
        public static void case_9() {
            int[] numbers = {1, 2, 3, 4};
            char[] chars = {'A', 'B', 'A', 'B'};

            // variante 1
            var pairs =
                from c in chars
                where c == 'A'
                from n in numbers
                where n % 2 == 0
                select c + n.ToString();
            Write("09.1) pairs: ", pairs, x => x + " ");
        }

        // orderby, thenby
        public static void case_10() {
            int[] numbers = {3, 2, 1, 6, 5, 4};

            // variante 1
            var nums1 =
                from n in numbers
                orderby n % 2
                select n;
            Write("10.1) nums1: ", nums1, x => x + " ");

            // variante 2
            var nums2 =
                from n in numbers
                orderby n % 2, n
                select n;
            Write("10.2) nums2: ", nums2, x => x + " ");

            // variante 3 ???
            var nums3 = numbers.OrderBy(n => (n % 2)).OrderBy(n => n);
            Write("10.3) nums3: ", nums3, x => x + " ");

            // variante 4
            var nums4 = numbers.OrderBy(n => (n % 2)).ThenBy(n => n).ThenBy(n => -n);
            Write("10.4) nums4: ", nums4, x => x + " ");
        }

        // grouping
        public static void case_11() {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            // variante 1
            var groups =
                from n in numbers
                orderby n
                group n by n % 3
                into g
                orderby g.Key
                select new {rem = g.Key, nums = g};

            foreach (var g in groups)
                Write("11.1) n%3=" + g.rem + ", nums1: ", g.nums, x => x + " ");

            // variante 2
            var counts =
                from n in numbers
                orderby n
                group n by n % 3
                into g
                orderby g.Key
                select new {rem = g.Key, cnt = g.Count()};

            foreach (var g in counts)
                Console.WriteLine("11.1) n%3={0}, cnt={1}", g.rem, g.cnt);
        }

        // aggregat operators
        public static void case_12() {
            int[] numbers = {3, 2, 1, 6, 5, 4};

            Console.WriteLine("12.1) numbers.count = " + numbers.Count());
            Console.WriteLine("12.2) numbers.cnt%5 = " + numbers.Count(n => (n % 5 == 1)));
            Console.WriteLine("12.3) numbers.min   = " + numbers.Min());
            Console.WriteLine("12.3) numbers.max%5 = " + numbers.Max(n => (n % 5)));
            Console.WriteLine("12.4) numbers.avg   = " + numbers.Average());
            Console.WriteLine("12.5) numbers.sum   = " + numbers.Sum());
            Console.WriteLine("12.6) numbers.sum%5 = " + numbers.Sum(n => (n % 5)));
        }

        // join
        public static void case_13() {
            var items = new[] {
                new {name = "Apfel", catid = 1},
                new {name = "Orange", catid = 1},
                new {name = "Banane", catid = 1},
                new {name = "Möhre", catid = 2},
                new {name = "Kolrabi", catid = 2}
            };

            var cats = new[] {
                new {name = "Obst", id = 1},
                new {name = "Gemüse", id = 2},
                new {name = "Pizza", id = 3}
            };

            var fullitems =
                from i in items
                join c in cats on i.catid equals c.id
                select new {name = i.name, cat = c.name};

            Write("13.1) iems: ", fullitems, item => "(" + item.name + ":" + item.cat + ") ");

            var fullitems2 =
                items.Join(cats, i => i.catid, c => c.id, (i, c) => new {name = i.name, cat = c.name});

            Write("13.2) iems: ", fullitems2, item => "(" + item.name + ":" + item.cat + ") ");
        }

        // set operators
        public static void case_14() {
            int[] numbers = {2, 2, 3, 5, 5};

            Write("14.1) distinct: ", numbers.Distinct(), x => x.ToString() + " ");

            var items = new[] {
                new {name = "Apfel", catid = 1},
                new {name = "Orange", catid = 1},
                new {name = "Möhre", catid = 2}
            };

            // mixed
            var catIDs = (
                    from i in items
                    select i.catid)
                .Distinct();

            Write("14.2) distinct: ", catIDs, x => x.ToString() + " ");
        }
    }
}