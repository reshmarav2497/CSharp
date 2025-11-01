using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaics
{
    internal class DataTypes
    {
        public void ShowDataTypes()
        {
            //Data types
            //can declare and assign value later

            //1. Integer
            int age = 25;
            Console.WriteLine($"Age: {age}");

            //2. Float
            float weight = 70.5f;
            Console.WriteLine($"Weight: {weight}");

            //3. Double
            double height = 5.9d;
            Console.WriteLine($"Height: {height}");

            //4. Boolean
            bool isStudent = true;
            Console.WriteLine($"Is Student: {isStudent}");

            //5. String
            string city = "New York";
            Console.WriteLine($"City: {city}");

            //6. Char
            char grade = 'A';
            Console.WriteLine($"Grade: {grade}");

            //7. Decimal
            decimal salary = 50000.75m;
            Console.WriteLine($"Salary: {salary}");

            //8. Byte
            byte level = 5;
            Console.WriteLine($"Level: {level}");

            //9. Short
            short temperature = 30;
            Console.WriteLine($"Temperature: {temperature}");

            //10. Long
            long distance = 1234567890L;
            Console.WriteLine($"Distance: {distance}");

            //11. var -> Implicitly typed variable
            // The compiler infers the type based on the assigned value
            // Here, 'country' is inferred to be of type string
            // once assigned, the type cannot be changed
            var country = "USA";
            Console.WriteLine($"Country: {country}");

            //Implicit conversion
            int num1 = 100;
            double num2 = num1; // int to double

            //Explicit conversion
            double num3 = 9.78;
            int num4 = (int)num3; // double to int
            Console.WriteLine($"Implicit Conversion: {num2}, Explicit Conversion: {num4}");

            //toString conversion
            int num5 = 42;
            string strNum = num5.ToString();
            Console.WriteLine($"String Conversion: {strNum}");

            //Constants
            // A constant value that cannot be changed
            // use uppercase letters with underscores for naming constants
            const double PI = 3.14159;
            Console.WriteLine($"Constant Pi: {PI}");

            //Convert input string to integer
            Console.WriteLine("Enter your age:");
            int Userage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age is: {Userage}");

        }
    }
}
