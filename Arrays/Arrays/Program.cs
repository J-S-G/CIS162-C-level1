using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter 10 integers to sum.");

            int[] integers = new int[10];

            var sum = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = Convert.ToInt32(Console.ReadLine());
                sum += integers[i];
            }
            Console.WriteLine($"The sum of the integers is: {sum}");
        }
    }
}
