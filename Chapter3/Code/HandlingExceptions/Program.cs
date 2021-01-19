using System;
using static System.Console;


namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is you age little boy? ");
            string input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old. ");
            }
            catch (OverflowException){
                WriteLine("Your age is a valid number format but it is eaither too big or too small");
            }
            catch (FormatException){
                WriteLine("The age you entered is not a valid number format. ");
            }
            catch (System.Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");
        }
    }
}
