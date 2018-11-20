using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            var daniel = new Student
            {
                FirstName = "Daniel",
                LastName = "Bider",
                Index = "222111"
            };

            var artur = new Programmer
            {
                FirstName = "Artur",
                LastName = "Solex",
                CSharp = SkillLevel.Intermediate,
                Java = SkillLevel.Basic,
                SightDefect = (0, 0)
            };

            var paweł = new Programmer
            {
                FirstName = "Paweł",
                LastName = "Żondzi",
                CSharp = SkillLevel.None,
                Java = SkillLevel.Expert,
                SightDefect = (-10.75, +12.5)
            };

            Console.WriteLine("Old way:");
            OldPrintInfo(daniel);
            OldPrintInfo(artur);
            OldPrintInfo(paweł);

            Console.WriteLine("\nNew way:");
            NewPrintInfo(daniel);
            NewPrintInfo(artur);
            NewPrintInfo(paweł);

            Console.ReadKey();
        }

        static void OldPrintInfo(Person p)
        {
            Console.WriteLine($"FirstName: {p.FirstName}");
            Console.WriteLine($"LastName: {p.LastName}");

            if (p is Student)
            {
                var s = (Student) p;
                Console.WriteLine($"Index: {s.Index}");
            }
            else if (p is Programmer)
            {
                var pr = (Programmer) p;
                Console.WriteLine($"CSharp: {pr.CSharp}");
                Console.WriteLine($"Java: {pr.Java}");
            }

            if (p is IHasSightDefect)
            {
                var hsd = (IHasSightDefect)p;
                Console.WriteLine($"SightDefect: {hsd.SightDefect}");
            }

            Console.WriteLine("-----------------------------------");
        }

        static void NewPrintInfo(Person p)
        {
            Console.WriteLine($"FirstName: {p.FirstName}");
            Console.WriteLine($"LastName: {p.LastName}");

            if (p is Student s)
            {
                Console.WriteLine($"Index: {s.Index}");
            }
            else if (p is Programmer pr)
            {
                Console.WriteLine($"CSharp: {pr.CSharp}");
                Console.WriteLine($"Java: {pr.Java}");
            }

            if (p is IHasSightDefect hsd)
            {
                Console.WriteLine($"SightDefect: {hsd.SightDefect}");
            }

            Console.WriteLine("-----------------------------------");
        }

        static void SafeCast()
        {
            object numbers = Enumerable.Range(-3, 10).ToArray();

            foreach (var number in numbers as IEnumerable<int>)
            {
                Console.WriteLine(number);
            }
        }
    }
}
