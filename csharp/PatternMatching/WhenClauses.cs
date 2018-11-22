using System;

namespace PatternMatching
{
    class WhenClauses
    {
        public static void Run()
        {
            var csharpGenius = new Programmer
            {
                FirstName = "CSharp",
                LastName = "Genius",
                CSharp = SkillLevel.Expert,
                Java = SkillLevel.None,
                SightDefect = (0, 1)
            };
            var javaGenius = new Programmer
            {
                FirstName = "Java",
                LastName = "Genius",
                CSharp = SkillLevel.None,
                Java = SkillLevel.Expert,
                SightDefect = (-0.5, 0)
            };
            var blindGenius = new Programmer
            {
                FirstName = "Blind",
                LastName = "Guy",
                CSharp = SkillLevel.Expert,
                Java = SkillLevel.Expert,
                SightDefect = (10.75, -12.5)
            };
            var intern = new Programmer
            {
                FirstName = "Mr.",
                LastName = "Intern",
                CSharp = SkillLevel.None,
                Java = SkillLevel.None,
                SightDefect = (0, 0)
            };
            var regular = new Programmer
            {
                FirstName = "Regular",
                LastName = "Guy",
                CSharp = SkillLevel.Basic,
                Java = SkillLevel.Basic,
                SightDefect = (-1, 0.75)
            };
            var student = new Student
            {
                FirstName = "Daniel",
                LastName = "Bider",
                Index = ""
            };


            Console.WriteLine("****OldPrintInfo****");

            OldPrintInfo(csharpGenius);
            OldPrintInfo(javaGenius);
            OldPrintInfo(blindGenius);
            OldPrintInfo(intern);
            OldPrintInfo(regular);
            OldPrintInfo(student);

            Console.WriteLine("****NewPrintInfo****");

            NewPrintInfo(csharpGenius);
            NewPrintInfo(javaGenius);
            NewPrintInfo(blindGenius);
            NewPrintInfo(intern);
            NewPrintInfo(regular);
            NewPrintInfo(student);

        }

        static void OldPrintInfo(Person p)
        {
            Console.WriteLine($"Person: {p.FirstName} {p.LastName}");

            if (p is IHasSightDefect)
            {
                var hsd = (IHasSightDefect)p;

                if (Math.Abs(hsd.SightDefect.leftEye) > 2 || Math.Abs(hsd.SightDefect.rightEye) > 2)
                {
                    Console.WriteLine("\tSight problems");
                }
            }
            // Can't put else here!
            if (p is Programmer)
            {
                var pr = (Programmer)p;

                if (pr.CSharp > SkillLevel.Basic || pr.Java > SkillLevel.Basic)
                {
                    Console.WriteLine("\tGreat programmer!");
                }
                else if (pr.CSharp == SkillLevel.None && pr.CSharp == SkillLevel.None)
                {
                    Console.WriteLine("\tNo skill :C. Go JavaScript");
                }
                else
                {
                    Console.WriteLine("\tRegular programmer");
                }
            }

            if (!(p is Programmer) && !(p is IHasSightDefect))
            {
                Console.WriteLine("\tNot a programmer, good sight");
            }

            Console.WriteLine("-----------------------------------");
        }

        static void NewPrintInfo(Person p)
        {
            Console.WriteLine($"Person: {p.FirstName} {p.LastName}");
            switch (p)
            {
                case IHasSightDefect hsd when Math.Abs(hsd.SightDefect.leftEye) > 2 || Math.Abs(hsd.SightDefect.rightEye) > 2:

                    Console.WriteLine("\tSight problems");
                    break;

                case Programmer pr when pr.CSharp > SkillLevel.Basic || pr.Java > SkillLevel.Basic:

                    Console.WriteLine("\tGreat programmer!");
                    break;

                case Programmer pr when pr.CSharp == SkillLevel.None && pr.CSharp == SkillLevel.None:

                    Console.WriteLine("\tNo skill :C. Go JavaScript");
                    break;

                case Programmer _:

                    Console.WriteLine("\tRegular programmer");
                    break;

                default:
                    Console.WriteLine("\tNot a programmer, good sight");
                    break;
            }

            Console.WriteLine("-----------------------------------");
        }
    }
}
