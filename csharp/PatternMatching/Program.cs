using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            SafeCast();

            WhenClauses.Run();

            SwitchMatching.Run();

            Console.ReadKey();
        }

        static void SafeCast()
        {
            object numbers = Enumerable.Range(-3, 10).ToList();

            foreach (var number in numbers as int[])
            {
                Console.WriteLine(number);
            }
        }
    }
}
