using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternMatchingGenerics
{
    static class OpenTypes
    {
        public static void Run()
        {
            var intDict = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3
            };
            var stringDict = new Dictionary<string, string>
            {
                ["one"] = "one",
                ["two"] = "two",
                ["three"] = "three"
            };
            Dictionary<string, int> nullDict = null;
            var longDict = new Dictionary<string, long>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3
            };

            PrintDictionaryInfo(intDict);
            PrintDictionaryInfo(stringDict);
            PrintDictionaryInfo(nullDict);
            PrintDictionaryInfo(longDict);
        }

        static void PrintDictionaryInfo<TValue>(Dictionary<string, TValue> dict)
        {
            var values = dict?.Values?.Aggregate("", (agg, v) => agg == "" ? v.ToString() : $"{agg}, {v}") ?? "No Values";

            switch (dict)
            {
                case Dictionary<string, int> intDict:

                    Console.WriteLine("This one holds ints");
                    var sum = intDict.Values.Sum();
                    Console.WriteLine("\tSum: " + sum);
                    break;

                case Dictionary<string, string> stringDict:

                    Console.WriteLine("This one holds strings");
                    var longest = stringDict
                        .Values
                        .Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
                    Console.WriteLine("\tLongest: " + longest);
                    break;

                case null:

                    Console.WriteLine("Ooops, it's null");
                    break;

                default:

                    Console.WriteLine($"I don't know this type: {typeof(TValue).FullName}");
                    break;
            }

            Console.WriteLine("\tValues: " + values);
        }
    }
}
