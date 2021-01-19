using System;
using static System.Console;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // 0000 1010
            int b = 6;  // 0000 0110
            WriteLine($"a = {a}");
            WriteLine($"a = {b}");
            WriteLine($"a & b = {a & b}"); // 0000 0010
            WriteLine($"a | b = {a | b}"); // 0000 1110 -> 8,4,2 bits set to 1
            WriteLine($"a ^ b = {a ^ b}"); // 0000 1100 -> 8 and 4 bit set to 1
            WriteLine($"a << 3 = {a << 3}"); // 0101 0000 - shift left 3 bits
            WriteLine($"a * 3 = {a * 3}"); // same result as above but shifting is faster
            WriteLine($"b >> 1 = {b >> 1}"); // 0000 0011 - shift right 1 bits
        }
    }
}