using System;

namespace Discards
{
    class StandaloneDiscard
    {
        public static void Run()
        {
            string numberString = "42";
            string wrongString = "kek";

            Parse(numberString);

            try
            {
                Parse(wrongString);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Couldn't parse '{wrongString}'");
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Throws exception if failed
        /// </summary>
        /// <param name="numberString"></param>
        /// <returns></returns>
        static void Parse(string numberString)
        {
            _ = int.Parse(numberString);

            Console.WriteLine("Parsed fine");
        }
    }
}
