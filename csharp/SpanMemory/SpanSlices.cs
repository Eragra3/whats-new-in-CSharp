using System;

namespace SpanMemory
{
    class SpanSlices
    {
        public static void Run()
        {
            var text = "A very nice string";

            ReadOnlySpan<char> readonlySpan =  text.AsSpan();

            ReadOnlySpan<char> slice = readonlySpan.Slice(2, 9);

            Console.WriteLine(slice.ToString());
        }
    }
}
