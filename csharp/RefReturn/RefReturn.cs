using System;

namespace RefReturn
{
    class RefReturn
    {
        public static void Run()
        {
            var evenNumbers = new MyArray(2, 4, 6, 8, 10);

            evenNumbers.Print();

            ref var number = ref evenNumbers[2];
            number = 3;

            evenNumbers.Print();
        }

        class MyArray
        {
            int[] numbers;

            public int Length => numbers.Length;

            public MyArray(params int[] numbers)
            {
                this.numbers = numbers;
            }

            internal ref int this[int index] => ref numbers[index];

            internal void Print()
            {
                foreach (var number in numbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
