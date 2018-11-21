using System;

namespace PatternMatchingGenerics
{
    static class GenericTypes
    {
        public static void Run()
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

            PrintInfo(daniel);
            PrintInfo(artur);
            PrintInfo(paweł);
        }

        static void PrintInfo<T>(T entity)
        {
            if (entity is Person p)
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

            }

            if (entity is IHasSightDefect hsd)
            {
                Console.WriteLine($"SightDefect: {hsd.SightDefect}");
            }

            Console.WriteLine("-----------------------------------");

        }
    }
}
