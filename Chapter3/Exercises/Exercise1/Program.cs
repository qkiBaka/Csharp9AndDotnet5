using System;
using static System.Console;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            try
            {
                WriteLine($"Dividing int {a} by 0: {a / 0}");
            }
            catch (DivideByZeroException){
                WriteLine("Catching DivideByZeroException, cannot do this stuff with int");
            }
            catch (System.Exception ex)
            {
                WriteLine($"{ex.GetType()} exception, message: {ex.Message} intresing, how did you get here :) ?");
            }
            
            double b = 1.2f;
            WriteLine($"Dividing double {b} by 0: {b/0}");
            
        }
    }
}
