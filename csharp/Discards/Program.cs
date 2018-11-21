using System;
using System.Threading.Tasks;

namespace Discards
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DeconstructionDiscard();

            OutDiscard();

            StandaloneDiscard();

            Console.ReadKey();
        }

        /// <summary>
        /// Check for right eye sight defect
        /// </summary>
        static void DeconstructionDiscard()
        {
            var artur = new Programmer
            {
                FirstName = "Artur",
                LastName = "Solex",
                CSharp = SkillLevel.Intermediate,
                Java = SkillLevel.Basic,
                SightDefect = (-1, 2.25)
            };

            var (_, lastName, (_, defect)) = artur;

            Console.WriteLine($"{lastName}'s sight defect is '{defect}'");
        }

        static void OutDiscard()
        {
            string numberString = "42";

            if (int.TryParse(numberString, out _))
            {
                Console.WriteLine("Hey, it's numeric");
            }
            else
            {
                Console.Error.WriteLine("That's a wrong number you got there");
            }
        }

        /// <summary>
        /// Throws exception if failed
        /// </summary>
        /// <returns></returns>
        static void StandaloneDiscard()
        {
            string numberString = "42";

            _ = int.Parse(numberString);
        }
    }
}
