using System;

namespace NonTrailingArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            LotsParameters("HelloWorld", ": ", "", ";");

            LotsParameters("HelloWorld", ": ", infix: "", postfix: ";");
            //LotsParameters("HelloWorld", ": ", infix: "", ";");
        }

        static void LotsParameters(
            string text,
            string prefix,
            string infix,
            string postfix)
        {
            throw new NotImplementedException();
        }
    }
}
