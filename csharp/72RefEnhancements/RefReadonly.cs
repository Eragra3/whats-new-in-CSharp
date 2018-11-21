using System;
using System.Collections.Generic;
using System.Text;

namespace _72RefEnhancements
{
    class RefReadonly
    {
        public static void Run()
        {
            int favNumber = 42;

            ref readonly var newFavNumber = ref GetReadonlyRef(favNumber);

            Console.WriteLine($"favNumber: {favNumber}");
            Console.WriteLine($"newFavNumber: {newFavNumber}");

            //newFavNumber = 10;
            favNumber = 10;
            
            Console.WriteLine($"favNumber: {favNumber}");
            Console.WriteLine($"newFavNumber: {newFavNumber}");
        }

        static ref readonly int GetReadonlyRef(in int number)
        {
            return ref number;
        }
    }
}
