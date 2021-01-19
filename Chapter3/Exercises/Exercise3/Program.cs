using System;
using static System.Console;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //First approach, successfull:
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if(i % 5 == 0)
                    {
                        WriteLine("FizzBuzz");
                    }
                    else
                    {
                        WriteLine("Fizz");
                    }
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        WriteLine("Buzz");
                    }
                    else
                    {
                        WriteLine(i);
                    }
                }
            }
            //Second appraoch, written in more elegant way, gives the same:
            WriteLine();
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0) )
                {
                    WriteLine("FizzBuzz");
                }
                else if(i % 3== 0){
                    WriteLine("Fizz");
                }
                else if (i % 5 == 0){
                    WriteLine("Buzz");
                }
                else {
                    WriteLine(i);
                }
            }

        }
    }
}

