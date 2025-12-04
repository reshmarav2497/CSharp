using System;

namespace CSharpBasics
{
    public class VariablesAndDataTypes
    {
        //readonly
        // can be assigned only once, either at declaration or in constructor
        // cannot be changed afterwards
        readonly int id;
        public VariablesAndDataTypes(int id)
        {
            this.id = id;
        }


        static void variablesAndDataTypes_Main()
        {
            // Variables & Data Types
            string message = "Hello World";

            int score;     // Declaration
            score = 100;   // Assignment

            // Integer
            int age = 25;

            // Long
            long worldPopulation = 8000000000;

            // Float
            float length = 4.3f;

            // Double
            double height = 5.11;
            double width = 8.5d;

            // Decimal
            decimal accountBalance = 1234.56m;

            // String
            string firstName = "John";

            //Boolean
            bool isStudent = true;

            // Implicit Type Conversion
            int number = 100;
            double biggerNumber = number;

            // Explicit Type Conversion
            double price = 99.99;
            int roundedPrice = (int)price;
            String value = roundedPrice.ToString();

            // Constant ->  compile time & static by default
            // Naming convention: UPPER_SNAKE_CASE
            // value cannot be changed after declaration
            const double TAX_RATE = 0.07;
            const string COMPANY_NAME = "Tech Corp";
            const int MAX_ATTEMPTS = 3;

            //var
            // The compiler infers the type based on the assigned value
            // Once assigned, the type cannot be changed
            var greeting = "Hello"; // String
            var studentCount = 30;  // Integer
            var temperature = 98.6; // Double

            //dynamic
            // Type is determined at runtime
            // The type can change during execution
            // Use with caution as it bypasses compile-time type checking
            dynamic data = "Hello"; // Initially a string
            data = 100;             // Now an integer
            data = 45.67;          // Now a double


            //convert a type to another type

            /*
             * Convert types
             * 1) Convert.ToInt32
             * 2) Convert.ToDouble
             * 3) Convert.ToString
             * 4) Convert.ToBoolean
             * 5) Convert.ToDecimal
             * 6) Convert.ToChar
             */

            //1) Using Convert class
            int intFromString = Convert.ToInt32("123");

            //2) Using Parse method
            double doubleFromString = double.Parse("123.45");

            //3) Using TryParse method
            string input = "456";
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine("Conversion successful: " + result);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }

            //4) Using ToString method
            int numberToConvert = 789;
            string stringFromInt = numberToConvert.ToString();

            //5) Get Type
            int x = 20;
            Console.WriteLine("The type of x is: " + x.GetType());


        }
    }
}
