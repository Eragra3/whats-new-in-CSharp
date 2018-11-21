using System;

namespace SpanMemory
{
    class SpanAllocation
    {
        private const int ArraySize = 1_000_00;

        public static void Run()
        {
            //RunUnsafe();

            RunSafe();
        }

        static void RunUnsafe()
        {
            unsafe
            {
                char* text = stackalloc char[ArraySize];

                text[10] = 'd';
                text[11] = 'u';
                text[12] = 'p';

                Console.Write(text[10]);
                Console.Write(text[11]);
                Console.Write(text[12]);
                Console.Write(text[13]);
                Console.WriteLine();
            }
        }

        static void RunSafe()
        {
            //Span<char> text = new char[ArraySize];
            Span<char> text = stackalloc char[ArraySize];

            text[10] = 'd';
            text[11] = 'u';
            text[12] = 'p';

            Console.Write(text[10]);
            Console.Write(text[11]);
            Console.Write(text[12]);
            Console.Write(text[13]);
            Console.WriteLine();
        }
    }
}
