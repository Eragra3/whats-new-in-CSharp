using System;

namespace OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string indexString = "42";

            int index;
            if (int.TryParse(indexString, out index))
            {
                int nextIndex = index + 1;

                Console.WriteLine($"Next person index is {nextIndex}");
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

            Console.ReadKey();
        }
    }
}
