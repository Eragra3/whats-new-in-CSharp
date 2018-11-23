using System;
using System.Threading.Tasks;

namespace Discards
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DeconstructionDiscard.Run();

            OutDiscard.Run();

            StandaloneDiscard.Run();

            Console.ReadKey();
        }
    }
}
