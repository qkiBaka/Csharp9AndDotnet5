using System;
using System.IO;
using static System.Console;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            // add and remove the "" to change the behavior
            object o = "3";
            int j = 4;
            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }

            string path = @"D:\Synchro\Nauka\CSharpLearn\Chapter3\Code";
            Write("Press R for readonly or W for write: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            Stream s = null;
            if (key.Key == ConsoleKey.R)
            {
                s = File.Open(
                  Path.Combine(path, "file.txt"),
                  FileMode.OpenOrCreate,
                  FileAccess.Read);
            }
            else
            {
                s = File.Open(
                  Path.Combine(path, "file.txt"),
                  FileMode.OpenOrCreate,
                  FileAccess.Write);
            }
            string message = string.Empty;
            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only file.";
                    break;
                case MemoryStream ms:
                    message = "The stream is a memory address.";
                    break;
                default: // always evaluated last despite its current position
                    message = "The stream is some other type.";
                    break;
                case null:
                    message = "The stream is null.";
                    break;
            }
            WriteLine(message);
        }
    }
}
