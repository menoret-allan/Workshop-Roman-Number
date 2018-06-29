namespace RomanNumber.Console
{
    using System;
    using RomanNumber.Core;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To exit the program, type 'exit' or press ctrl-C");
            var romanNumber = new RomanNumber();
            Console.CancelKeyPress += (_, e) => Exit();
            
            while (true)
            {
                Console.Write("Enter the number that you want to convert: ");
                var line = Console.ReadLine();
                if (line == "exit")
                {
                    Exit();
                }
                else
                {
                    Console.WriteLine(int.TryParse(line, out var number)
                        ? $"Roman number for {number} is: {romanNumber.NumberToRoman(number)}"
                        : $"The input {line} is not a number.");
                }
            }
        }

        static void Exit()
        {
            Console.WriteLine("See you soon!! <3");
            Environment.Exit(1);
        }
    }
}
