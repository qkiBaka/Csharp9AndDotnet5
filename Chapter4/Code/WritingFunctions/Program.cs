﻿using static System.Console;
namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine(
                  $"{row} x {number} = {row * number}");
            }
            WriteLine();
        }
        static void RunTimesTable(){
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(
                  ReadLine(), out byte number);
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }
        /// <summary>
        /// Pass a 32-bit Int and it will be converted into its ordinal equivalent.
        /// </summary>
        /// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so on.</param>
        /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;
                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th" 
                    };
                    return $"{number}{suffix}";
            }
        }

        static void RunCardinalToOrdinal(){
            for (int number = 0; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
            WriteLine();
        }

        static int Factorial(int number)
        {
            if (number < 1){
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                checked
                {
                    return number * Factorial(number - 1);
                }
            }
        }

        static void RunFactorial()
        {
            for(int i = 0; i <= 15; i++)
            {
                try
                {
                    WriteLine($"{i}! = {Factorial(i):N0}");
                }
                catch (System.OverflowException)
                {
                    WriteLine($"{i}! is too big for a 32-bit integer.");
                }
            }
        }
        static int FibImperative(int term){
            if(term == 1)
            {
                return 0;
            }
            else if (term == 2){
                return 1;
            }
            else{
                return FibImperative(term - 1) + FibImperative(term - 2);
            }
        }

        static void RunFibImperative(){
            for (int i = 1; i <= 30; i++)
            {
                WriteLine("The {0} term of Fibonacci sequence is {1:N0}.",
                arg0: CardinalToOrdinal(i),
                arg1: FibImperative(term: i)
                );
            }
        }
        static int FibFunctional(int term) =>
            term switch
            {
                1 => 0,
                2 => 1,
                _ => FibFunctional(term - 1) + FibFunctional(term - 2)
            };
        static void RunFibFunctional(){
            for (int i = 1; i <= 30; i++)
            {
                WriteLine("The {0} term of the Fibonacci sequence is {1:N0}. "
                    arg0: CardinalToOrdinal(i),
                    arg1: FibFunctional(term: i)
                );
            }
        }
        static void Main(string[] args)
        {
            // RunTimesTable();
            // RunCardinalToOrdinal();
            // RunFactorial();
            RunFibImperative();
        }
    }
}