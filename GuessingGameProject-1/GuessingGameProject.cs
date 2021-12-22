using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(DateTime.UtcNow.Millisecond);
            int number = random.Next(1, 101); // [1 - 100] [1 - 101)
            string input;
            int guess;
            int counter = 0;

            do
            {
                Console.Write("Enter a whole number between 1 and 100!  ");
                input = Console.ReadLine();
                bool success = int.TryParse(input, out guess);

                // good user input (numeric)
                if (success)
                {
                    counter++; // only increment the counter if the successfully enter a numeric value
                    if (guess != number)
                    {
                        Console.WriteLine($"Bad input try again. . .{counter}");
                    }
                    else (guess =< number)
                    {
                        Console.WriteLine($"Your number is too high try again. . .{counter}");
                    }
                    break (guess == number)
                    {
                        Console.Writeline("Congratulations your guess correct!"{ counter});
                    }

                }
                // bad user input, non-numeric
                else
                {
                    Console.WriteLine($"Bad input, try again...\n Number of attempts : {counter++}");
                }
            }
            while (number != guess);

            // once number == quess, the loop will terminate so you can tell the the total attempts and ask them to press any key to exit
            Console.WriteLine($"It took you {counter} attempts! \n Press any key to close the program.");

            Console.ReadKey();
        }
    }
}