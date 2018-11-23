using System;
using System.Collections.Generic;

namespace LocalFunctions
{
    class EagerValidation
    {
        public static void Run()
        {
            IEnumerable<int> ienum = GoodOddSequence(100, 0);
            //IEnumerable<int> ienum = BadOddSequence(100, 0);

            foreach (var i in ienum)
            {
                Console.Write($"{i} ");
            }
        }

        static IEnumerable<int> BadOddSequence(int start, int end)
        {
            if (start >= end)
            {
                throw new ArgumentException("start must be less than end.");
            }

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 1)
                {
                    yield return i;
                }
            }
        }

        static IEnumerable<int> GoodOddSequence(int start, int end)
        {
            if (start >= end)
            {
                throw new ArgumentException("start must be less than end.");
            }

            return GetOddSequenceEnumerator();

            IEnumerable<int> GetOddSequenceEnumerator()
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 1)
                    {
                        yield return i;
                    }
                }
            }
        }
    }
}
