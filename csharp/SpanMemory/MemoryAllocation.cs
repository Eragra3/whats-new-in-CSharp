using System;
using System.Threading.Tasks;

namespace SpanMemory
{
    class MemoryAllocation
    {
        public static void Run()
        {
            var buffer = new Memory<byte>(new byte[1024]);

            DoSomethingAsync(buffer).GetAwaiter().GetResult();
        }

        //static async Task SpanAsync(Span<byte> buffer)
        //{
        //    var v1 = buffer[0];
        //    v1 = 2;

        //    await Task.Delay(1000);

        //    var v2 = buffer[1];
        //}
        
        static async Task DoSomethingAsync(Memory<byte> buffer) {
            var v1 = buffer.Span[0];
            v1 = 2;

            await Task.Delay(1000);

            var v2 = buffer.Span[1];
        }
    }
}
