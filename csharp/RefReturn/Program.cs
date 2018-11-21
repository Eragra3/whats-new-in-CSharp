using System;

namespace RefReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            RefReturn.Run();
            RefReturnRefLocal.Run();

            Console.ReadKey();
        }
    }
}
