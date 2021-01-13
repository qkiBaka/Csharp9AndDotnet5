using System;
using System.Globalization;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            // Displays the same value with a blank as the separator.
            nfi.NumberGroupSeparator = "";
            Console.WriteLine($"{"Type",-10} {"Bytes",5} {"Min",30} {"Max",30}");
            Console.WriteLine($"{"sbyte",-10} {sizeof(sbyte),5} {sbyte.MinValue.ToString(),30} {sbyte.MaxValue.ToString(),30}" );
            Console.WriteLine($"{"byte",-10} {sizeof(byte),5} {byte.MinValue.ToString(),30} {byte.MaxValue.ToString(),30}");
            Console.WriteLine($"{"short",-10} {sizeof(short),5} {short.MinValue.ToString(),30} {short.MaxValue.ToString(),30}" );
            Console.WriteLine($"{"ushort",-10} {sizeof(sbyte),5} {ushort.MinValue.ToString(),30} {ushort.MaxValue.ToString(),30}");
            Console.WriteLine($"{"int",-10} {sizeof(int),5} {int.MinValue.ToString(),30} {int.MaxValue,30}");
            Console.WriteLine($"{"uint",-10} {sizeof(uint),5} {uint.MinValue.ToString(),30} {uint.MaxValue,30}");
            Console.WriteLine($"{"long",-10} {sizeof(long),5} {long.MinValue.ToString(),30} {long.MaxValue,30}");
            Console.WriteLine($"{"ulong",-10} {sizeof(ulong),5} {ulong.MinValue.ToString(),30} {ulong.MaxValue,30}");
            Console.WriteLine($"{"float",-10} {sizeof(float),5} {float.MinValue.ToString(),30:E0} {float.MaxValue,30}" );
            Console.WriteLine($"{"double",-10} {sizeof(double),5} {double.MinValue.ToString(),30} {double.MaxValue,30}");
            Console.WriteLine($"{"decimal",-10} {sizeof(decimal),5} {decimal.MinValue.ToString(),30} {decimal.MaxValue,30}");

            
        }
    }
}