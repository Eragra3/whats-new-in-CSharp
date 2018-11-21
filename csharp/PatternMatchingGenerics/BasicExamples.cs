using System;

namespace PatternMatchingGenerics
{
    class BasicExamples
    {
        public static void Run()
        {
            var s = "Some string";
            var n = 42;
            var o = new {Anonymous = "object"};

            WhatAmI(s);
            WhatAmI(n);
            WhatAmI(o);

            Action<string> sa = _ => Console.WriteLine();
            Action<int> na = _ => Console.WriteLine();
            Action<object> oa = _ => Console.WriteLine();

            WhatAmIExactly(sa);
            WhatAmIExactly(na);
            WhatAmIExactly(oa);
        }

        public static void WhatAmI<T>(T me)
        {
            switch (me)
            {
                case int _:
                    Console.WriteLine("I'm an int");
                    break;
                case string _:
                    Console.WriteLine("I'm a string");
                    break;
                case object _:
                    Console.WriteLine("I'm an object");
                    break;
                default:
                    Console.WriteLine("I'm a ninja");
                    break;
            }
        }

        public static void WhatAmIExactly<TParam>(Action<TParam> me)
        {
            switch (me)
            {
                case Action<int> _:
                    Console.WriteLine("I return an int");
                    break;
                case Action<object> _:
                    Console.WriteLine("I return an object");
                    break;
                case Action<string> _:
                    Console.WriteLine("I return a string");
                    break;
                default:
                    Console.WriteLine("I'm a ninja");
                    break;
            }
        }
    }
}
