using System;
using System.Collections.Generic;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            HelperMethods.Run();

            EagerValidation.Run();

            Console.ReadKey();
        }
    }
}
