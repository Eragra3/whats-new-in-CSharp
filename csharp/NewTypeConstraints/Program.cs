using System;

namespace NewTypeConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void RequireEnum<T>(T param) where T: Enum
        {
            throw new NotImplementedException();
        }

        static void RequireDelegate<T>(T param) where T: Delegate
        {
            throw new NotImplementedException();
        }

        static void RequireUnmanaged<T>(T param) where T: unmanaged
        {
            throw new NotImplementedException();
        }
    }
}
