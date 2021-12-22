using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number: ");

            string input1 = Console.ReadLine();

            int number1;

            bool success = int.TryParse(input1, out number1);

            if (success)
            {
                Console.WriteLine($"You entered a number: {number1}");
            }
            else
            {
                Console.WriteLine($"You did not enter a number: {input1}");
            }


            Console.WriteLine($"Press 'Enter' to find out if your integer is even or odd");
            {
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            }
            if (number1%2 == 0)

            {
                Console.WriteLine("Number is even");
            }
            else 
            { 
                Console.WriteLine("Number is odd");
            }
           













        }
     }
 }

