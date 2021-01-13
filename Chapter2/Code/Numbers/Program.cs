using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint naturalNumber = 23;
            int integerNumber = -23;
            float realNumber = 2.3F;
            double biggerRealNumber = 2.3;

            // intresting: you can use underscore _ in literal digit and it will be fine, makes reading easier

            int decimalNotaion = 2_000_000;
            Console.WriteLine("Decimal notation 2_000_000 value : {0}",decimalNotaion);

            int binaryNotation = 0b_0001_1110;
            Console.WriteLine("Binary notation 0b_0001_1110 is : {0}", binaryNotation);

            int hexNotation = 0x_AE_2B;
            Console.WriteLine("Hex notation 0x_AE_2B is : {0}", hexNotation);

            Console.WriteLine();

            // and now the classic - how much memory each type uses:
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range \n {int.MinValue:N0} \n to \n {int.MaxValue:N0}. \n");
            Console.WriteLine($"long uses {sizeof(long)} bytes and can store numbers in the range \n {long.MinValue:N0} \n to \n {long.MaxValue:N0}. \n");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range from: \n {double.MinValue:N0} \n to \n {double.MaxValue:N0}.\n");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range \n {decimal.MinValue:N0} \n to \n {decimal.MaxValue:N0}.\n");
            Console.WriteLine($"float uses {sizeof(float)} bytes and can store numbers in the range \n {float.MinValue:N0} \n to \n {float.MaxValue:N0}.\n");

            Console.WriteLine();

            // comparing double to decimal
            Console.WriteLine("Using doubles:");
            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }

            Console.WriteLine("Well a+b using double equals to = {0}",a+b);
            // Yeah decimal 0.1 has infinite numers after . in binary = always some rounding errors
            // NEVER use '==' to compare doubles
            
            Console.WriteLine();

            Console.WriteLine("Using decimals:");
            decimal c = 0.1M; // M suffix means a decimal literal value
            decimal d = 0.2M;
            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }

            Console.WriteLine($"{c} + {d} equals to: {0:F}",c+d); 
        }
    }
}
