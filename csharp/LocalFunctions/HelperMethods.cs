using System;

namespace LocalFunctions
{
    class HelperMethods
    {
        public static void Run()
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
    }
}
