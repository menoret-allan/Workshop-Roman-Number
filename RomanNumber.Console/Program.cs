using System;

namespace RomanNumber
{
    using Core;

    class Program
    {
        private static bool continueToPlay = true;

        static void Main(string[] args)
        {
            Console.WriteLine("To exit the program, type 'exit' or press ctrl-C");
            var romanNumber = new RomanNumber();
            Console.CancelKeyPress += (_, e) => Environment.Exit(1);
            
            while (continueToPlay)
            {
                Console.Write("Enter the number that you want to translate: ");
                var line = Console.ReadLine();
                if (continueToPlay == false || line == "exit")
                {
                    continueToPlay = false;
                }
                else
                {
                    Console.WriteLine(int.TryParse(line, out var number)
                        ? $"Roman number for {number} is: {romanNumber.NumberToRoman(number)}"
                        : $"The input {line} is not a number.");
                }
            }

            Console.WriteLine("See you soon!! <3");
        }
    }
}
