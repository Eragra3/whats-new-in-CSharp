using System;

namespace _72RefEnhancements
{
    class Program
    {
        static void Main(string[] args)
        {
            InParameters.Run();

            RefReadonly.Run();

            ReadonlyStruct.Run();

            Console.ReadKey();
        }
    }
}
