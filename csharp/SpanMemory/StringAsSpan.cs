using System;

namespace SpanMemory
{
    class StringAsSpan
    {
        public static void Run()
        {
            var text = "A very nice string";

            ReadOnlySpan<char> readonlySpan =  text.AsSpan();

            ref readonly var firstLetter = ref readonlySpan[0];

            //firstLetter = 'N';

            Console.WriteLine(firstLetter);
        }
    }
}
