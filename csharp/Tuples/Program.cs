using System;
using System.Linq;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new []{ -3, -2, -1, 0, 1, 2, 3, 4 ,5, 6 };

            {
                var oldResult = OldTuples(numbers);
                Console.WriteLine(oldResult);

                var newResult = NewTuples(numbers);
                Console.WriteLine(newResult);
            }

            {
                var oldResult = OldTuplesLinq(numbers);
                Console.WriteLine(oldResult);

                var newResult = NewTuplesLinq(numbers);
                Console.WriteLine(newResult);
            }
            Console.ReadKey();
        }

        #region Vanilla

        static Tuple<int, double, int> OldTuples(int[] numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            foreach (var number in numbers)
            {
                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
            }

            double avg = sum / numbers.Length;

            var result = new Tuple<int, double, int>(min, avg, max);
            return result;
        }

        static (int min, double avg, int max) NewTuples(int[] numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            foreach (var number in numbers)
            {
                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
            }

            double avg = sum / numbers.Length;

            var result = (min, avg, max);
            return result;
        }

        #endregion

        #region LINQ

        static Tuple<int, double, int> OldTuplesLinq(int[] numbers)
        {
            var minSumMax = numbers.Aggregate(new Tuple<int, int, int>(int.MaxValue, 0, int.MinValue),
                (acc, n) => new Tuple<int, int, int>(
                    Math.Min(acc.Item1, n),
                    acc.Item2 + n,
                    Math.Max(acc.Item3, n)
                    )
                );

            var result = new Tuple<int, double, int>(minSumMax.Item1, minSumMax.Item2 / numbers.Length, minSumMax.Item3);
            return result;
        }

        static (int min, double avg, int max) NewTuplesLinq(int[] numbers)
        {
            var (min, sum, max) = numbers.Aggregate((min: int.MaxValue, sum: 0, max: int.MinValue),
                (acc, n) => (
                    Math.Min(acc.min, n),
                    acc.sum + n,
                    Math.Max(acc.max, n)
                    )
                );

            var result = (min, sum / numbers.Length, max);
            return result;
        }

        #endregion
    }
}
