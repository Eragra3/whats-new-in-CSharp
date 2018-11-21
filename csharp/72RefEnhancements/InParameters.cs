using System;
using System.Collections.Generic;
using System.Text;

namespace _72RefEnhancements
{
    class InParameters
    {
        public static void Run()
        {
            var i = 10;

            Print(i);
            Print(in i);
            
            var daniel = new Student
            {
                FirstName = "Daniel",
                LastName = "Bider",
                Index = "222111"
            };

            Print(daniel);
        }

        static void Print(in int number)
        {
            Console.WriteLine(number);
        }

        static void Print(int number)
        {
            Console.WriteLine(number);
        }
        
        //static void Print(Person p)
        //{
        //    Console.WriteLine(p);
        //}
        
        static void Print(in Person p)
        {
            //p = null;
            p.FirstName = "Artur";

            Console.WriteLine(p.FirstName);
        }
    }
}
