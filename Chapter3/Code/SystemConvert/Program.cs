using System;
using static System.Console;
using static System.Convert;

namespace SystemConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and g is {h}");

            WriteLine("Rounding:");
            double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51};
            foreach (double n in doubles)
            {
                WriteLine($"ToInt({n}) is {ToInt32(n)}");
            }
            foreach (double n in doubles)
            {
                WriteLine(format: 
                "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                arg0: n,
                arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero
                ));
            }

            WriteLine();
            WriteLine("String Convertions:");
            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());

            WriteLine();
            WriteLine("Binary object to string - Base64:");
            byte[] binaryObject = new byte[128];
            (new Random()).NextBytes(binaryObject);
            WriteLine("Binary Obect as bytes:");
            for(int index = 0; index < binaryObject.Length; index++){
                Write($"{binaryObject[index]:X} ");
            }
            WriteLine();
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64: {encoded}");

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("26 September 1994");
            WriteLine($"I was born {age} years ago");
            //O.o When I'm writing this code I have 27 as in book :D
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");

            Write("How many chickens are there? ");
            int count;
            string input = ReadLine();
            if (int.TryParse(input, out count))
            {
                WriteLine($"There are {count} chickens.");
            }
            else {
                WriteLine("I couldn't parse the input");
            }
        }
    }
}
