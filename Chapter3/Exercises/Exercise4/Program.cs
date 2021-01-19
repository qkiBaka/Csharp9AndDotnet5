using System;
using static System.Console;
using static System.Convert;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number between 0 and 255: ");
            string input = ReadLine();
            byte a = 0;
            try
            {
                a = ToByte(input);
            }
            catch (FormatException)
            {
                WriteLine("Does not contain number");
                return;
            }
            catch (OverflowException)
            {
                WriteLine("This value is not from the proper range");
                return;
            }
            catch (System.Exception ex)
            {
                WriteLine($"Exception: {ex.GetType()} with message: {ex.Message}");
            }
            Write("Enter another number between 0 and 255: ");
            input = ReadLine();
            byte b = 0;
            try
            {
                b = ToByte(input);
            }
            catch (FormatException)
            {
                WriteLine("Does not contain number");
                return;
            }
            catch (OverflowException)
            {
                WriteLine("This value is not from the proper range");
                return;
            }
            catch (System.Exception ex)
            {
                WriteLine($"Exception: {ex.GetType()} with message: {ex.Message}");
            }
            try
            {
                WriteLine($"{a} divaded by {b} is {a / b}");
            }
            catch (DivideByZeroException)
            {
                WriteLine("Cannot divide by zero");
            }
            catch (System.Exception ex)
            {
                WriteLine($"Exception: {ex.GetType()} with message: {ex.Message}");
            }
        }
    }
}
