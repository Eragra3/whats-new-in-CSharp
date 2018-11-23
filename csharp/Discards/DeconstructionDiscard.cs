using System;

namespace Discards
{
    class DeconstructionDiscard
    {
        public static void Run()
        {
            var artur = new Programmer
            {
                FirstName = "Artur",
                LastName = "Solex",
                CSharp = SkillLevel.Intermediate,
                Java = SkillLevel.Basic,
                SightDefect = (-1, 2.25)
            };

            FindSightDefect(artur);
        }

        /// <summary>
        /// Check for right eye sight defect
        /// </summary>
        static void FindSightDefect(Programmer artur)
        {
            var (_, lastName, (_, defect)) = artur;

            Console.WriteLine($"{lastName}'s sight defect is '{defect}'");
        }
    }
}
