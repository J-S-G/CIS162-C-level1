using System;

namespace ExceptionAndExcetionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            bool success1 = TryParse(null, out value);
            Console.WriteLine($"Successful? {success1}");
            bool success2 = TryParse("five", out value);
            Console.WriteLine($"Successful? {success2}");
            bool success3 = TryParse("100000000000000000000000000", out value);
            Console.WriteLine($"Successful? {success3}");
            bool success4 = TryParse("42", out value);
            Console.WriteLine($"Successful? {success4}");
            Console.WriteLine($"Value {value}");
        }

        static bool TryParse(string input, out int value)
        {
            value = 0;

            // You cannot catch only Exception, you must catch and handle 3 types of exceptions:
            // - ArgumentNullException
            // - FormatException
            // - OverflowException
            value = int.Parse(input);
            return true;
        }
    }
}