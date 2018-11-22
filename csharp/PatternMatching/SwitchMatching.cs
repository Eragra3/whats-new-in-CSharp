using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMatching
{
    class SwitchMatching
    {
        public static void Run()
        {

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
    }
}
