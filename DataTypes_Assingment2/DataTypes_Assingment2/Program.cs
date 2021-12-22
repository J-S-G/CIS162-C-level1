using System;

namespace DataTypes_Assingment2
{
    class Program
    {//Addition = sum
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number: ");

            string input1 = Console.ReadLine();

            int input1Asint = int.Parse(input1);

            Console.WriteLine("Enter a second whole number");

            string input2 = Console.ReadLine();

            int input2Asint = int.Parse(input2);

            int sum = input1Asint + input2Asint;

            Console.WriteLine($"{ input1Asint} + { input2Asint} = {sum}");

            //subtraction = difference

            Console.Write("Enter a whole number: ");

            string input3 = Console.ReadLine();

            int input3Asint = int.Parse(input3);

            Console.WriteLine("Enter a second whole number");

            string input4 = Console.ReadLine();

            int input4Asint = int.Parse(input4);

            int difference = input3Asint - input4Asint;

            Console.WriteLine($"{ input3Asint} - { input4Asint} = {difference}");

            // multiplication = product 

            Console.Write("Enter a whole number: ");

            string input5 = Console.ReadLine();

            int input5Asint = int.Parse(input5);

            Console.WriteLine("Enter a second whole number");

            string input6 = Console.ReadLine();

            int input6Asint = int.Parse(input6);

            int product = input5Asint * input6Asint;

            Console.WriteLine($"{ input5Asint} * { input6Asint} = {product}");

            // division = quotient 

            Console.Write("Enter a whole number: ");

            string input7 = Console.ReadLine();

            int input7Asint = int.Parse(input7);

            Console.WriteLine("Enter a second whole number");

            string input8 = Console.ReadLine();

            int input8Asint = int.Parse(input8);

            int quotient = input7Asint / input8Asint;

            Console.WriteLine($"{ input7Asint} / { input8Asint} = {quotient}");










        }
    }
}
