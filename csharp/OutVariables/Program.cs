using System;

namespace OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = "42";

            int number;
            if (int.TryParse(numberString, out number))
            {
                int nextIndex = number + 1;

                Console.WriteLine($"Next person number is {nextIndex}");
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

            Console.ReadKey();
        }
    }
}
