using System;
using System.IO;
using System.Xml;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");

            // object type - messier code, worse performance = don't use
            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object
            Console.WriteLine($"{name} is {height} metres tall.");
            //int length1 = name.Length; // gives compile error!
            //type object has no length property
            int length2 = ((string)name).Length; // tell compiler it is a string
            Console.WriteLine($"{name} has {length2} characters.");

            // dynamic type - messier code, even worse performance than above = don't use
            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";
            // this compiles but would throw an exception at run-time
            // if you later store a data type that does not have a
            // property named Length
            int length = anotherName.Length;

            int population = 66_000_000; // 66 million in UK 
            double weight = 1.88; // in kilograms
            decimal price = 4.99M; // in pounds sterling
            string fruit = "Apples"; // strings use double-quotes
            char letter = 'Z'; // chars use single-quotes
            bool happy = true; // Booleans have value of true or false

            var vpopulation = 66_000_000; // 66 million in UK 
            var vweight = 1.88; // in kilograms
            var vprice = 4.99M; // in pounds sterling
            var vfruit = "Apples"; // strings use double-quotes 
            var vletter = 'Z'; // chars use single-quotes
            var vhappy = true; // Booleans have value of true or false

            /*
            // good use of var because it avoids the repeated type
            // as shown in the more verbose second statement
            var xml1 = new XmlDocument();
            XmlDocument xml2 = new XmlDocument();
            // bad use of var because we cannot tell the type, so we 
            // should use a specific type declaration as shown in 
            // the second statement
            var file1 = File.CreateText(@"C:\something.txt");
            StreamWriter file2 = File.CreateText(@"C:\something.txt");
            */
            // C# 9 new feature
            XmlDocument xml3 = new(); // target-typed new in C# 9

            Console.WriteLine();
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

        }        
    }
}
