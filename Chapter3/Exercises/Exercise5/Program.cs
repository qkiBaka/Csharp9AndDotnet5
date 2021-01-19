using System;
using static System.Console;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 2 + ++x;
            // First x is incremented, x will be 4, then 2 will be added so 6 will be assigned to y
            WriteLine(y);

            x = 3 << 2;
            //Bit shifting 2 places left for 3 so multiplining two times by two: 3*2*2 = 12
            //0b0011 -> 0b1100 so 12 in decimal
            WriteLine(x);

            y = 10 >> 1;
            // shifting right by one place so dividing by 2: 10/5 =2
            // 10 is 0b1010 shifting right by one so 0b0101 it's 5 in decimal
            WriteLine(y);

            x = 10 & 8;
            /* Binary logical AND:
              1010
              1000
              ----
              1000
              Will be decimal 8
            */
            WriteLine(x);

            y = 10 | 7;
            /* Binary logical OR
              1010
              0111
              ----
              1111
              Will be decimal 15
            */
            WriteLine(y);
        }
    }
}
