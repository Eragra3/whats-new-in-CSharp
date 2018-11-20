using PatternMatching;
using System;
using System.Collections.Generic;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var paweł = new Programmer
            {
                FirstName = "Paweł",
                LastName = null,
                CSharp = SkillLevel.None,
                Java = SkillLevel.Expert,
                SightDefect = (0.0, 0.0)
            };

            NewPrintInterestingInfo(paweł, 10);
            OldPrintInterestingInfo(paweł, 10);
            MehPrintInterestingInfo(paweł, 10);

            #region enumerator
            //IEnumerable<int> ienum = GoodOddSequence(0, 100);
            IEnumerable<int> ienum = BadOddSequence(0, 100);

            foreach (var i in ienum)
            {
                Console.Write($"{i} ");
            }
            #endregion

            Console.ReadKey();
        }

        static void OldPrintInterestingInfo(Programmer p, int indentationSize)
        {
            var indentation = new string(' ', indentationSize);

            Console.WriteLine("Person:");
            OldPrintIndented(p.FirstName, indentation);
            OldPrintIndented(p.LastName, indentation);
            OldPrintIndented(p.CSharp, indentation);
            OldPrintIndented(p.Java, indentation);
            OldPrintIndented(p.SightDefect, indentation);
        }

        static void OldPrintIndented(object o, string indentation)
        {
            var text = o ?? "<NA>";
            Console.WriteLine(indentation + text);
        }

        static void MehPrintInterestingInfo(Programmer p, int indentationSize)
        {
            var indentation = new string(' ', indentationSize);

            Action<object> printIndented = o =>
            {
                var text = o ?? "<NA>";
                Console.WriteLine(indentation + text);
            };

            Func<int>[] clb = new Func<int>[10];
            for (int i = 0; i < 10; i++)
            {
                clb[i] = () => i;
            }

            Console.WriteLine("Person:");
            printIndented(p.FirstName);
            printIndented(p.LastName);
            printIndented(p.CSharp);
            printIndented(p.Java);
            printIndented(p.SightDefect);
        }

        static void NewPrintInterestingInfo(Programmer p, int indentationSize)
        {
            var indentation = new string(' ', indentationSize);

            Console.WriteLine("Person:");
            PrintIndented(p.FirstName);
            PrintIndented(p.LastName);
            PrintIndented(p.CSharp);
            PrintIndented(p.Java);
            PrintIndented(p.SightDefect);

            void PrintIndented(object o)
            {
                var text = o ?? "<NA>";
                Console.WriteLine(indentation + text);
            }
        }

        #region enumerator
        public static IEnumerable<int> BadOddSequence(int start, int end)
        {
            if (start >= end)
            {
                throw new ArgumentException("start must be less than end.");
            }

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 1)
                {
                    yield return i;
                }
            }
        }

        public static IEnumerable<int> GoodOddSequence(int start, int end)
        {
            if (start >= end)
            {
                throw new ArgumentException("start must be less than end.");
            }

            return GetOddSequenceEnumerator();

            IEnumerable<int> GetOddSequenceEnumerator()
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 1)
                    {
                        yield return i;
                    }
                }
            }
        }
        #endregion
    }
}
