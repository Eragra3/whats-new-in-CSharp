using System;

namespace Discards
{
    class OutDiscard
    {
        public static void Run()
        {
            string numberString = "42";

            TryParse(numberString);
        }

        static void TryParse(string numberString)
        {
            if (int.TryParse(numberString, out _))
            {
                Console.WriteLine("Hey, it's numeric");
            }
            else
            {
                Console.Error.WriteLine("That's a wrong number you got there");
            }
        }
    }
}
