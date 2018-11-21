using System;

namespace SpanMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            SpanAllocation.Run();

            StringAsSpan.Run();

            SpanSlices.Run();

            MemoryAllocation.Run();

            Console.ReadKey();
        }
    }
}
