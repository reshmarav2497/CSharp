using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Course_Content
{
    static class Strings
    {
        public static void StringOperations()
        {
            //String
            /*
             * -> String is a refernce type
             * -> Immutable (cannot be changed after creation)
             * -> each modified string creates a new string in memory
             */

            string firstName = "John";
            string lastName = "Doe";

            // Concatenation
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full Name: " + fullName);

            // Interpolation
            string greeting = $"Hello, {firstName} {lastName}!";
            Console.WriteLine(greeting);

            // Substring
            string sub = fullName.Substring(0, 4); // "John"
            Console.WriteLine("Substring: " + sub);

            // Length
            int length = fullName.Length;
            Console.WriteLine("Length of Full Name: " + length);

            // ToUpper and ToLower
            Console.WriteLine("Uppercase: " + fullName.ToUpper());
            Console.WriteLine("Lowercase: " + fullName.ToLower());

            // Replace
            string replaced = fullName.Replace("John", "Jane");
            Console.WriteLine("Replaced Name: " + replaced);

            //Split
            string[] names = fullName.Split(' '); // split the string by comma
            string newString = string.Join(",", names);
            Console.WriteLine("Split Names: " + newString);

            //Verbatim string
            //-> Useful for file paths and multi-line strings
            //-> makes the string ignore escape sequences
            string filePath = @"C:\Users\JohnDoe\Documents\File.txt";

            //Null and Empty Checks
            string emptyString = "";

            if(string.IsNullOrEmpty(emptyString))
            {
                Console.WriteLine("The string is either null or empty.");
            }

            if(string.IsNullOrWhiteSpace("   "))
            {
                Console.WriteLine("The string is either null, empty, or consists only of white-space characters.");
            }

            //Escape sequences
            string escapeExample = "First Line\nSecond Line\tTabbed";
            Console.WriteLine("Escape Example: " + escapeExample);
        }
    }
}
