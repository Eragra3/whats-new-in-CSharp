using System;
using System.Collections.Generic;
using System.Text;

namespace RefReturn
{
    static class RefReturnRefLocal
    {
        public static void Run()
        {
            int favNumber = 42;

            ref int newFavNumber = ref Add10(ref favNumber);

            Console.WriteLine($"favNumber: {favNumber}");
            Console.WriteLine($"newFavNumber: {newFavNumber}");

            newFavNumber = 0;

            Console.WriteLine();
            Console.WriteLine($"favNumber: {favNumber}");
            Console.WriteLine($"newFavNumber: {newFavNumber}");

            favNumber = 69;

            Console.WriteLine();
            Console.WriteLine($"favNumber: {favNumber}");
            Console.WriteLine($"newFavNumber: {newFavNumber}");
        }

        static ref int Add10(ref int number)
        {
            number += 10;
            return ref number;
        }
    }
}
