using System;
using System.Collections.Generic;

namespace DefaultValues
{
    class BasicExamples
    {
        public static void Run()
        {
            //variable initialization
            IDictionary<string, int> dictionary = default;

            var printer = new MyPrinter("some name");

            //default parameter value
            printer.Print("It's me", default);
        }

        class MyPrinter
        {
            private readonly string _name;
            private readonly string _defaultIndentation;

            //default parameter value
            public MyPrinter(string name, int defaultIndentation = default)
            {
                _name = name;
                _defaultIndentation = new string(' ', defaultIndentation);
                Console.WriteLine($"Created MyPrinter with name '{_name}'");
            }

            public void Print(object v, string prefix = ": ")
            {
                Console.WriteLine(_defaultIndentation + prefix + v);
            }
        }
    }
}
